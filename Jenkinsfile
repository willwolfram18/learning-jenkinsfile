#!/usr/bin/env groovy
pipeline {
    agent any
    stages {
        stage('Stage 1') {
            steps {
                echo 'Hello world!'
            }
        }
        stage('Stage 2') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}