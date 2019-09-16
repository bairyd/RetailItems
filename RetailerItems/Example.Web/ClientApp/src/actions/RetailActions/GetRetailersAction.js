import { API } from './../actionTypes'

import { GET_RETAILER_BEGIN, GET_RETAILER_SUCCESS, GET_RETAILER_FAILURE }
    from "../../constants/ActionTypes"

const getRetailerBegin = () => ({
    type: GET_RETAILER_BEGIN
});

const getRetailerSuccess = (retailer) => ({
    type: GET_RETAILER_SUCCESS,
    payload: { ...retailer }
});

const getRetailerFailure = (error) => ({
    type: GET_RETAILER_FAILURE,
    payload: error
});

export function getRetailer(retailerId) {
    return dispatch => {
        dispatch({
            type: API,
            payload: {
                url: `/api/Retailers/${retailerId}`,
                method: "GET",
                data: requestData(retailerId),
                onBegin: () => { return getRetailerBegin() },
                onSuccess: (response) => {
                    const retailer = response.result;
                    return getRetailerSuccess(retailer);
                },
                onFailure: (response) => { return getRetailerFailure(response.message); },
                label: GET_RETAILER_BEGIN,
                headersOverride: null
            }
        });
    }
}

function requestData(retailerId) {
    return ({
        Id: retailerId
    })
}
