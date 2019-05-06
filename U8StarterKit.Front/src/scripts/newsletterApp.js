import Vue from 'vue';
import VeeValidate from 'vee-validate'
import newsletterForm from '../vue-components/newsletter-form.vue'

Vue.use(VeeValidate, {
    events: 'change'
});

axios.interceptors.response.use(function (response) {
    if (response.status === 400) {
        return Promise.reject(response);
    }
    if (response.status === 500) {
        return Promise.reject(response);
    }
    return response;
}, function (error) {
    return Promise.reject(error);
});

function newsletterApp() {
    new Vue({
        el: 'app-news-letter',
        components: {
            newsletterForm
        }
    });
};
module.exports = newsletterApp;
