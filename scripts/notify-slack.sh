#!/bin/bash

# post_to_slack channel username icon message hook
function post_to_slack () {
	template='{"channel":"%s","username":"%s","icon_emoji":"%s","text":"%s"}'
	json_string=$(printf "$template" "${1}" "${2}" "${3}" "${4}")
	curl -d "${json_string}" \
		--url "${5}" \
		-H 'Content-Type: application/json' \
		-H 'Accept: application/json'

}

chn="#general"
msg="*Jenkins build on ${JOB_NAME} is failing!* s: _${STAGE_NAME}_\n${BUILD_TAG}\nJenkins: ${BUILD_URL}\nBlueOcean: ${RUN_DISPLAY_URL}\nGitHub: ${GIT_URL} ${GIT_BRANCH}\n"
icn=":broken_heart:"
usr="jenkins"
hook=https://hooks.slack.com/services/scooper/dooper/pooper

post_to_slack "${chn}" "${usr}" "${icn}" "${msg}" "${hook}"
