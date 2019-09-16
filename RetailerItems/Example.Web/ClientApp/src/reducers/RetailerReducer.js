import {
    GET_RETAILER_BEGIN, GET_RETAILER_SUCCESS, GET_RETAILER_FAILURE
} from "../constants/ActionTypes";

const initialState = {
    retailer: {},
    isLoading: false,
    error: null
};

const retailerReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_RETAILER_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_RETAILER_SUCCESS:
            return {
                ...state,
                retailer: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_RETAILER_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default retailerReducer