import axios from 'axios';

export const api  = axios.create({
    baseURL: 'https://nqowemdzgcywxcxegltq.supabase.co/rest/v1',
    headers: {
        apikey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im5xb3dlbWR6Z2N5d3hjeGVnbHRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEwOTM4OTcsImV4cCI6MjA0NjY2OTg5N30.SK6PZToGMQP11nUYEgBSTavnJ6-Blk4LVNzWraSA68Y",
        authorization: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im5xb3dlbWR6Z2N5d3hjeGVnbHRxIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEwOTM4OTcsImV4cCI6MjA0NjY2OTg5N30.SK6PZToGMQP11nUYEgBSTavnJ6-Blk4LVNzWraSA68Y"
    }
})