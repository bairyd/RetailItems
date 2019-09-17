import { API_START, API_END, ACCESS_DENIED, API_ERROR } from "../actions/actionTypes";
// import { isAuthenticated, renewUserSession, redirectLoggedOutUser } from './../actions/auth/index';

const initialState = {
    label: "",
    url: "",
    error: ""
};

export default function (state = initialState, { type, payload }) {
    switch (type) {
        case API_START:
            // if (isAuthenticated()) {
            //     renewUserSession();
            // } else {
            //     redirectLoggedOutUser();
            // }
            return {
                ...state,
                label: payload,
            };
        case API_END:
            return {
                ...state,
                label: payload,
            };
        case ACCESS_DENIED:
            return {
                ...state,
                url: payload
            };
        case API_ERROR:
            return {
                ...state,
                error: payload
            };
        default:
            return state
    }
};