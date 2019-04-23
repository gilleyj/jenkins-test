#!/bin/bash

SLACK_WEBHOOK=https://hooks.slack.com/services/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

echo "notify slack"

json_escape () {
    printf '%s' "$1" | python -c 'import json,sys; print(json.dumps(sys.stdin.read()))'
}

# post_to_slack channel username icon message hook
function post_to_slack () {
	channel="\"channel\":$(json_escape "${1}"),"
	user="\"username\":$(json_escape "${2}"),"
	icon="\"icon_emoji\":$(json_escape "${3}"),"
	text="\"text\":$(json_escape "${4}"),"
	hook=$5
	
	payload="payload={$channel$user$icon$text}"
	echo "$(curl -s -S --data-urlencode "$payload" "$hook" 2>&1)"
}

chn="#general"
msg="Jenkins build on ${JOB_NAME} - ${BRANCH_NAME} at ${JENKINS_URL} ${GIT_URL} ${GIT_BRANCH} is failing!"
icn=":ambulance:"
usr="jenkins"

post_to_slack ${chn} ${usr} ${icn} "${msg}" ${SLACK_WEBHOOK}
