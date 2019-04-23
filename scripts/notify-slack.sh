#!/bin/bash

SLACK_WEBHOOK=https://hooks.slack.com/services/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

apt install -y jq

echo "notify slack"

json_escape () {
    printf '%s' "$1" | python -c 'import json,sys; print(json.dumps(sys.stdin.read()))'
}

# post_to_slack channel username icon message hook
function post_to_slack () {
	jq -n \
		--arg chn "${1}" \
		--arg usr "${2}" \
		--arg icn "${3}" \
		--arg msg "${4}" \
		'{ channel: $chn, username: $usr, icon_emoji: $icn, text: $msg }' \
	| \
	curl -d @- \
		--url "${5}" \
		-H 'Content-Type: application/json' \
		-H 'Accept: application/json'

}

chn="#general"
msg="Jenkins build on ${JOB_NAME} - ${BRANCH_NAME} at ${JENKINS_URL} ${GIT_URL} ${GIT_BRANCH} is failing!"
icn=":ambulance:"
usr="jenkins"

post_to_slack ${chn} ${usr} ${icn} "${msg}" ${SLACK_WEBHOOK}
