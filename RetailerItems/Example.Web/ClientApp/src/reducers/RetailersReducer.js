import {
    GET_RETAILERS_BEGIN, GET_RETAILERS_SUCCESS, GET_RETAILERS_FAILURE
} from "../constants/ActionTypes";

const initialState = {
    retailers: {},
    isLoading: false,
    error: null
};

const retailersReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_RETAILERS_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_RETAILERS_SUCCESS:
            return {
                ...state,
                retailers: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_RETAILERS_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default retailersReducer