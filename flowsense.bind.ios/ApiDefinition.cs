using Foundation;

// @interface Service_fs : NSObject
[BaseType (typeof(NSObject))]
interface Service_fs
{
	// +(void)StartFlowsenseService:(NSString * _Nonnull)partnerToken;
	[Static]
	[Export ("StartFlowsenseService:")]
	void StartFlowsenseService (string partnerToken);

	// +(void)StartFlowsenseService:(NSString * _Nonnull)partnerToken :(BOOL)startNow;
	[Static]
	[Export ("StartFlowsenseService::")]
	void StartFlowsenseService (string partnerToken, bool startNow);

	// +(NSDictionary * _Nonnull)getPushExtras;
	[Static]
	[Export ("getPushExtras")]
	//[Verify (MethodToProperty)]
	NSDictionary PushExtras { get; }

	// +(void)StartMonitoringLocation;
	[Static]
	[Export ("StartMonitoringLocation")]
	void StartMonitoringLocation ();

	// +(void)updatePartnerUserIdiOS:(NSString * _Nonnull)userId;
	[Static]
	[Export ("updatePartnerUserIdiOS:")]
	void UpdatePartnerUserIdiOS (string userId);

	// +(void)updateGeofences;
	[Static]
	[Export ("updateGeofences")]
	void UpdateGeofences ();

	// +(NSArray * _Nonnull)getStoredGeofences;
	[Static]
	[Export ("getStoredGeofences")]
	//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
	NSObject[] StoredGeofences { get; }

	// +(NSArray * _Nonnull)getKeyValues;
	[Static]
	[Export ("getKeyValues")]
	//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
	NSObject[] KeyValues { get; }
}
