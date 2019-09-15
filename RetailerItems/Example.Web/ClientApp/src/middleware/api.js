import axios from "axios";
import { API } from "../actions/actionTypes";
import { accessDenied, apiError, apiStart, apiEnd } from "../actions/api/api";
import settings from "./../settings.json";

import {
    getAccessToken
} from '../utils/utils';

const BASE_URL = settings.ApiRootUrl || "";

const defaultHeaders = {};
let headers = { ...defaultHeaders };

const apiMiddleware = ({ dispatch }) => next => action => {
    next(action);

    if (action.type !== API) return;

    const {
        url,
        method,
        data,
        onBegin,
        onSuccess,
        onFailure,
        label,
        headersOverride
    } = action.payload;
    const dataOrParams = ["GET", "DELETE"].includes(method) ? "params" : "data";

    let accessToken = getAccessToken();

    if (accessToken) {
        headers = {
            ...headers,
            Authorization: `Bearer ${accessToken}`
        };
    }

    if (headersOverride) {
        headers = {
            ...headers,
            ...headersOverride
        };
    }

    if (label) {
        dispatch(apiStart(label));
    }

    if (onBegin){
        dispatch(onBegin());
    }

    axios
        .request({
            url: `${BASE_URL}${url}`,
            method,
            headers,
            [dataOrParams]: data
        })
        .then(({ data }) => {
            if (label) {
                dispatch(apiEnd(label));
            }
            dispatch(onSuccess(data));
        })
        .catch(error => {
            if (label) {
                dispatch(apiEnd(label));
            }
            dispatch(apiError(error));
            dispatch(onFailure(error));

            if (error.response && error.response.status === 403) {
                dispatch(accessDenied(window.location.pathname));
            }
        });
};

export default apiMiddleware;