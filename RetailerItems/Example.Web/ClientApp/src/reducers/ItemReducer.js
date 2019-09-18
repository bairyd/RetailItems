import {
    GET_ITEM_BEGIN, GET_ITEM_SUCCESS, GET_ITEM_FAILURE, ADD_ITEM_BEGIN, ADD_ITEM_SUCCESS, ADD_ITEM_FAILURE
} from "../constants/ActionTypes";

const initialState = {
    item: {},
    isLoading: false,
    error: null
};

const itemReducer = (state = initialState, { type, payload }) => {
    switch (type) {
        case GET_ITEM_BEGIN:
        case ADD_ITEM_BEGIN:
            return {
                ...state,
                isLoading: true,
                error: null
            };

        case GET_ITEM_SUCCESS:
        case ADD_ITEM_SUCCESS:
            return {
                ...state,
                item: {
                    ...payload
                },
                isLoading: false,
                error: null
            };

        case GET_ITEM_FAILURE:
        case ADD_ITEM_FAILURE:
            return {
                ...state,
                isLoading: false,
                error: payload
            };

        default:
            return state
    }
};

export default itemReducer