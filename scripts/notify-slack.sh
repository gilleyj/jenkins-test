#!/bin/bash

SLACK_WEBHOOK=https://hooks.slack.com/services/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

echo "notify slack"

# post_to_slack channel username icon message hook
function post_to_slack () {
	SLACK_CHANNEL=$1
	SLACK_USER=$2
	SLACK_ICON=$3
	SLACK_MESSAGE="\`\`\`$2\`\`\`"
	SLACK_URL=$4

	curl -X POST --data "payload={\"text\": \"${SLACK_MESSAGE}\", \"channel\": \"${SLACK_CHANNEL}\", \"username\": \"${SLACK_USER}\", \"icon_emoji\": \"${SLACK_ICON}\"}" ${SLACK_URL}
}

chn="#general"
msg="Jenkins build on ${JOB_NAME} - ${BRANCH_NAME} at ${JENKINS_URL} ${GIT_URL} ${GIT_BRANCH} is failing!"
icn=":ambulance:"
usr="gilleyj"

post_to_slack ${chn} ${usr} ${icn} ${msg} ${SLACK_URL}
