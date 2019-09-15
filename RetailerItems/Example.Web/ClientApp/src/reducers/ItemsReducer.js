import {
    GET_ITEMS_BEGIN, GET_ITEMS_SUCCESS, GET_ITEMS_FAILURE
} from "../Constants/ActionTypes";

const initialState = {
    items: {},
    isLoading: false,
    error: null
};

const itemsReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_ITEMS_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_ITEMS_SUCCESS:
            return {
                ...state,
                item: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_ITEMS_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default itemsReducer