import { API } from './../actionTypes'

import { GET_LOCATIONS_BEGIN, GET_LOCATIONS_SUCCESS, GET_LOCATIONS_FAILURE }
    from "../../constants/ActionTypes"

const getLocationsBegin = () => ({
    type: GET_LOCATIONS_BEGIN
});

const getLocationsSuccess = (locations) => ({
    type: GET_LOCATIONS_SUCCESS,
    payload: { ...locations }
});

const getLocationsFailure = (error) => ({
    type: GET_LOCATIONS_FAILURE,
    payload: error
});

export function getLocations() {
    return dispatch => {
        dispatch({
            type: API,
            payload: {
                url: '/api/Locations',
                method: "GET",
                onBegin: () => { return getLocationsBegin() },
                onSuccess: (response) => {
                    return getLocationsSuccess(response.response);
                },
                onFailure: (response) => { return getLocationsFailure(response.message); },
                label: GET_LOCATIONS_BEGIN,
                headersOverride: null
            }
        });
    }
}

// function requestData(retailerId) {
//     return ({
//         Id: retailerId
//     })
// }
