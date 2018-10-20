#!/usr/bin/env groovy
pipeline {
    agent any
    script {
        def testPassed = true
    }
    stages {
        stage('Build') {
            steps {
                echo 'Hello world!'
            }
        }
        stage('Test') {
            steps {
                echo "Tests FAILED"
                testPassed = false
            }
        }
        stage('Deploy') {
            when {
                expression {
                    return testPassed
                }
            }
            setps {
                echo "Deploying"
            }
        }
    }
}