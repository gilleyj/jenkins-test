pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
                sh "scripts/notify-slack.sh"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
                echo "Testing ${env.BUILD_ID} on ${env.JENKINS_URL}"
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
                echo "Deploying ${env.BUILD_ID} on ${env.JENKINS_URL}"
            }
        }
    }
}
