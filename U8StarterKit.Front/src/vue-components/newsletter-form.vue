<template>
<div>
    <form @submit.prevent="validateBeforeSubmit" v-show="!submitted">
        <div class="field">
            <div class="control has-icons-left has-icons-right">
                <input 
                    class="input is-medium" 
                    type="email" 
                    placeholder="Name, eg. Matt Barlow"
                    v-model="newsletterForm.name"
                    v-validate="'required'"
                    name="name"
                    >
                    <span class="icon is-left">
                        <i class="fas fa-user fa-sm"></i>
                    </span>
                    <span class="icon is-right">
                        <i class="fas fa-check fa-sm"></i>
                    </span>
            </div>
            <span class="field-validation-error" v-if="errors.has('name')">{{ errors.first('name') }}</span>
        </div>
        <div class="field">
            <div class="control has-icons-left has-icons-right">
                <input 
                    class="input is-medium" 
                    type="email" 
                    placeholder="Email, eg. email@email.com"
                    v-model="newsletterForm.email"
                    v-validate="'required|email'"
                    name="email"
                    
                    />
                <span class="icon is-left">
                    <i class="fas fa-envelope fa-sm"></i>
                </span>
                <span class="icon is-right">
                    <i class="fas fa-check fa-sm"></i>
                </span>
            </div>
            <span class="field-validation-error" v-if="errors.has('email')">{{ errors.first('email') }}</span>
        </div>
        <div class="field">
            <div class="control">
                <button type="submit" class="is-link button is-medium" :class="{ 'is-loading': isLoading }">Sign up</button>
            </div>
        </div>
    </form>
    <div v-show="submitted">
        <div>
            <p>Form Submitted</p>
        </div>
    </div> 
</div>
</template>

<script>
    import axios from 'axios';

    export default {
        data (){
            return {
                api: '',
                isLoading: false,
                submitted: false,
                submittedError: false,
                newsletterForm: {
                    name: '',
                    email: ''
                }
            }
        },
        methods: {
            validateBeforeSubmit() {
                this.$validator.validate().then(result => {
                    if (result) {
                        this.handleSubmit();
                        self.submittedError = false;
                        self.submittedForm();
                    }
                });
            },
            submittedForm(){
                this.submitted = true;
            },
            handleSubmit() {
                self = this;
                self.isLoading = true;
                axios
                    .post(this.api, this.newsLetterForm, {
                        headers: {'Content-Type': 'application/json'}
                    })
                    .then(function(response){n
                        self.isLoading = false;

                    })
                     .catch(function(error){ 
                        self.isLoading = false;
                        self.submittedError = true;
                        self.submittedForm();
                    });
            }
        }
    }
</script>