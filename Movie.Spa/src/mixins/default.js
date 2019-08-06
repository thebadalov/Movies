import { createDecipher } from "crypto";

const apiUrl = 'http://localhost:62324/api/';

export default {
    data() {
        return {
            apiKey: null,
            blogDataItems: []
        }
    },

    methods: {
        async postData(data) {
            const vm = this;

            const response = await fetch(`${apiUrl}${vm.apiKey}`, {
                method: "POST", // *GET, POST, PUT, DELETE, etc.
                mode: "cors", // no-cors, cors, *same-origin
                credentials: "same-origin",
                headers: {
                    "Content-Type": "application/json",
                    "Authorization": 'Basic ' + btoa(`${vm.$root.user.email}:${vm.$root.user.password}`)
                },
                referrer: "no-referrer",  // no-referrer, *client
                body: JSON.stringify(data)
            })            
             //.catch(alert("Email or Password is incorrect, fill again!!!"))

            return await response.json()
        },

        async getData() {
            const vm = this;

            const request = await fetch(`${apiUrl}${vm.apiKey}`, {
                method: "GET",
                mode: "cors",
                credentials: "same-origin",
                headers: {
                    "Content-Type": "application/json"
                },
                referrer: "no-referrer"
            });

            const response = await request.json();
            
            return response;
        }
    },
    
}