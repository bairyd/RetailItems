import { API } from './../actionTypes'

import { GET_ITEMS_BEGIN, GET_ITEMS_SUCCESS, GET_ITEMS_FAILURE }
    from "../../constants/ActionTypes"

const getItemsBegin = () => ({
    type: GET_ITEMS_BEGIN
});

const getItemsSuccess = (items) => ({
    type: GET_ITEMS_SUCCESS,
    payload: { ...items }
});

const getItemsFailure = (error) => ({
    type: GET_ITEMS_FAILURE,
    payload: error
});

export function getItemsByLocation(locationId) {
    return dispatch => {
        dispatch({
            type: API,
            payload: {
                url: '/api/Items/Location',
                method: "GET",
                data: requestData(locationId),
                onBegin: () => { return getItemsBegin() },
                onSuccess: (response) => {
                    return getItemsSuccess(response.response);
                },
                onFailure: (response) => { return getItemsFailure(response.message); },
                label: GET_ITEMS_BEGIN,
                headersOverride: null
            }
        });
    }
}

function requestData(locationId) {
    return ({
        Id: locationId
    })
}
