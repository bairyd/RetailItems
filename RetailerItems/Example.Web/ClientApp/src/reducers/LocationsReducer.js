import {
    GET_LOCATIONS_BEGIN, GET_LOCATIONS_SUCCESS, GET_LOCATIONS_FAILURE
} from "../constants/ActionTypes";

const initialState = {
    locations: [],
    isLoading: false,
    error: null
};

const locationsReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_LOCATIONS_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_LOCATIONS_SUCCESS:
            return {
                ...state,
                locations: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_LOCATIONS_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default locationsReducer