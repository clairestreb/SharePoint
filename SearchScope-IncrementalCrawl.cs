//We cannot perform an incremental crawl of a search scope, but we can get a content source and incrementall crawl that

SearchServiceApplicationProxy proxy = SearchServiceApplicationProxy.GetProxy(SPServiceContext.Current);
Guid appId = ssap.GetSearchServiceApplicationInfo().SearchServiceApplicationId;
SearchServiceApplication app = SearchService.Service.SearchApplications.GetValue<SearchServiceApplication>(appId);
Content content = new Content(app)

ContentSource cs = content.ContentSources["contentSourceName"];
cs.StartIncrementalCrawl();
// check on cs.CrawlStatus if finished