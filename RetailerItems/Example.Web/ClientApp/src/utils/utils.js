import atob from 'atob';
import { Constants } from '../constants/Constants'

export const getIdToken = () => {
    const idToken = localStorage.getItem(Constants.API.Id_Token);
    if (!idToken) {
        throw new Error('No id token found');
    }
    return idToken;
};

export const getAccessToken = () => {
    const accessToken = localStorage.getItem(Constants.API.Access_Token);
    if (!accessToken) {
        window.location.assign('/');
    }
    return accessToken;
};

export const getClaimFromToken = (token, claim) => {
    let payload = token.split('.')[1];
    let bin = atob(payload);
    let obj = JSON.parse(bin);
    return obj[claim];
};