import os
from newscatcherapi_client import Newscatcher

newscatcher = Newscatcher(api_key=os.environ["NEWSCATCHER_API_KEY"])
latest_headlines = newscatcher.latest_headlines.post(body={"lang": "en"})
print(latest_headlines)