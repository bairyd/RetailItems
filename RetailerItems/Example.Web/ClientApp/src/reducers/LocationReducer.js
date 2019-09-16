import {
    GET_LOCATION_BEGIN, GET_LOCATION_SUCCESS, GET_LOCATION_FAILURE
} from "../constants/ActionTypes";

const initialState = {
    location: {},
    isLoading: false,
    error: null
};

const locationReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_LOCATION_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_LOCATION_SUCCESS:
            return {
                ...state,
                location: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_LOCATION_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default locationReducer