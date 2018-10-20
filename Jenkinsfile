#!/usr/bin/env groovy
pipeline {
    agent any
    stages {
        stage('Set up') {
            steps {
                script {
                    def testPassed = true
                }
            }
        }
        stage('Build') {
            steps {
                echo 'Hello world!'
            }
        }
        stage('Test') {
            steps {
                echo "Tests FAILED"
                script {
                    testPassed = false
                }
            }
        }
        stage('Deploy') {
            when {
                expression {
                    return testPassed
                }
            }
            steps {
                echo "Deploying"
            }
        }
    }
}