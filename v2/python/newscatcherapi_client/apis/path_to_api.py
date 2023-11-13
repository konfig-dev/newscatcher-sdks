import typing_extensions

from newscatcherapi_client.paths import PathValues
from newscatcherapi_client.apis.paths.search import Search
from newscatcherapi_client.apis.paths.latest_headlines import LatestHeadlines
from newscatcherapi_client.apis.paths.sources import Sources

PathToApi = typing_extensions.TypedDict(
    'PathToApi',
    {
        PathValues.SEARCH: Search,
        PathValues.LATEST_HEADLINES: LatestHeadlines,
        PathValues.SOURCES: Sources,
    }
)

path_to_api = PathToApi(
    {
        PathValues.SEARCH: Search,
        PathValues.LATEST_HEADLINES: LatestHeadlines,
        PathValues.SOURCES: Sources,
    }
)
