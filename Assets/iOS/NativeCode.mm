extern "C" void IOS13BannerTestScript_ShowController() {
	NSLog(@"IOS13BannerTestScript_ShowController");
    CustomViewController* controller = [[CustomViewController alloc] init];
    [[GetAppController() rootViewController] presentModalViewController:controller animated:YES];
}