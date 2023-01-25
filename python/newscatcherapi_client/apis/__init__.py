
# flake8: noqa

# Import all APIs into this package.
# If you have many APIs here with many many models used in each API this may
# raise a `RecursionError`.
# In order to avoid this, import only the API that you directly need like:
#
#   from newscatcherapi_client.api.latest_headlines_api import LatestHeadlinesApi
#
# or import this package, but before doing it, use:
#
#   import sys
#   sys.setrecursionlimit(n)

# Import APIs into API package:
from newscatcherapi_client.api.latest_headlines_api import LatestHeadlinesApi
from newscatcherapi_client.api.search_api import SearchApi
from newscatcherapi_client.api.sources_api import SourcesApi
