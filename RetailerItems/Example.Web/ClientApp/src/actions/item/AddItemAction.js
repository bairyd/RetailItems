import { API } from './../actionTypes'

import { ADD_ITEM_BEGIN, ADD_ITEM_SUCCESS, ADD_ITEM_FAILURE }
    from "../../constants/ActionTypes"

const addItemBegin = () => ({
    type: ADD_ITEM_BEGIN
});

const addItemSuccess = (items) => ({
    type: ADD_ITEM_SUCCESS,
    payload: { ...items }
});

const addItemFailure = (error) => ({
    type: ADD_ITEM_FAILURE,
    payload: error
});

export function addItem(item) {
    return dispatch => {
        dispatch({
            type: API,
            payload: {
                url: "/api/items",
                method: "POST",
                data: item,
                onBegin: () => { return addItemBegin() },
                onSuccess: (response) => {
                    return addItemSuccess(response.response);
                },
                onFailure: (response) => { return addItemFailure(response.message); },
                label: ADD_ITEM_BEGIN,
                headersOverride: null
            }
        });
    };
}

// function commandData(item) {
//    
//     formData.append('commandData', JSON.stringify(commandData));
//     formData.append('commandType', 'CreatePaymentInstructionCommand');
//     return formData;
// };
