using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']"
	[global::Android.Runtime.Register ("com/umeng/message/entity/UMessage", DoNotGenerateAcw=true)]
	public partial class UMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='DISPLAY_TYPE_AUTOUPDATE']"
		[Register ("DISPLAY_TYPE_AUTOUPDATE")]
		public const string DisplayTypeAutoupdate = (string) "autoupdate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='DISPLAY_TYPE_CUSTOM']"
		[Register ("DISPLAY_TYPE_CUSTOM")]
		public const string DisplayTypeCustom = (string) "custom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='DISPLAY_TYPE_NOTIFICATION']"
		[Register ("DISPLAY_TYPE_NOTIFICATION")]
		public const string DisplayTypeNotification = (string) "notification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='NOTIFICATION_GO_ACTIVITY']"
		[Register ("NOTIFICATION_GO_ACTIVITY")]
		public const string NotificationGoActivity = (string) "go_activity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='NOTIFICATION_GO_APP']"
		[Register ("NOTIFICATION_GO_APP")]
		public const string NotificationGoApp = (string) "go_app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='NOTIFICATION_GO_CUSTOM']"
		[Register ("NOTIFICATION_GO_CUSTOM")]
		public const string NotificationGoCustom = (string) "go_custom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='NOTIFICATION_GO_URL']"
		[Register ("NOTIFICATION_GO_URL")]
		public const string NotificationGoUrl = (string) "go_url";

		static IntPtr activity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='activity']"
		[Register ("activity")]
		public string Activity {
			get {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, activity_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (activity_jfieldId == IntPtr.Zero)
					activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, activity_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr after_open_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='after_open']"
		[Register ("after_open")]
		public string AfterOpen {
			get {
				if (after_open_jfieldId == IntPtr.Zero)
					after_open_jfieldId = JNIEnv.GetFieldID (class_ref, "after_open", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, after_open_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (after_open_jfieldId == IntPtr.Zero)
					after_open_jfieldId = JNIEnv.GetFieldID (class_ref, "after_open", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, after_open_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr alias_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='alias']"
		[Register ("alias")]
		public string Alias {
			get {
				if (alias_jfieldId == IntPtr.Zero)
					alias_jfieldId = JNIEnv.GetFieldID (class_ref, "alias", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, alias_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (alias_jfieldId == IntPtr.Zero)
					alias_jfieldId = JNIEnv.GetFieldID (class_ref, "alias", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, alias_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr builder_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='builder_id']"
		[Register ("builder_id")]
		public int BuilderId {
			get {
				if (builder_id_jfieldId == IntPtr.Zero)
					builder_id_jfieldId = JNIEnv.GetFieldID (class_ref, "builder_id", "I");
				return JNIEnv.GetIntField (Handle, builder_id_jfieldId);
			}
			set {
				if (builder_id_jfieldId == IntPtr.Zero)
					builder_id_jfieldId = JNIEnv.GetFieldID (class_ref, "builder_id", "I");
				JNIEnv.SetField (Handle, builder_id_jfieldId, value);
			}
		}

		static IntPtr custom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='custom']"
		[Register ("custom")]
		public string Custom {
			get {
				if (custom_jfieldId == IntPtr.Zero)
					custom_jfieldId = JNIEnv.GetFieldID (class_ref, "custom", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, custom_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (custom_jfieldId == IntPtr.Zero)
					custom_jfieldId = JNIEnv.GetFieldID (class_ref, "custom", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, custom_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr display_type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='display_type']"
		[Register ("display_type")]
		public string DisplayType {
			get {
				if (display_type_jfieldId == IntPtr.Zero)
					display_type_jfieldId = JNIEnv.GetFieldID (class_ref, "display_type", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, display_type_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (display_type_jfieldId == IntPtr.Zero)
					display_type_jfieldId = JNIEnv.GetFieldID (class_ref, "display_type", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, display_type_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr extra_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='extra']"
		[Register ("extra")]
		public global::System.Collections.IDictionary Extra {
			get {
				if (extra_jfieldId == IntPtr.Zero)
					extra_jfieldId = JNIEnv.GetFieldID (class_ref, "extra", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, extra_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (extra_jfieldId == IntPtr.Zero)
					extra_jfieldId = JNIEnv.GetFieldID (class_ref, "extra", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, extra_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr icon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='icon']"
		[Register ("icon")]
		public string Icon {
			get {
				if (icon_jfieldId == IntPtr.Zero)
					icon_jfieldId = JNIEnv.GetFieldID (class_ref, "icon", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, icon_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (icon_jfieldId == IntPtr.Zero)
					icon_jfieldId = JNIEnv.GetFieldID (class_ref, "icon", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, icon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr img_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='img']"
		[Register ("img")]
		public string Img {
			get {
				if (img_jfieldId == IntPtr.Zero)
					img_jfieldId = JNIEnv.GetFieldID (class_ref, "img", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, img_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (img_jfieldId == IntPtr.Zero)
					img_jfieldId = JNIEnv.GetFieldID (class_ref, "img", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, img_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr largeIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='largeIcon']"
		[Register ("largeIcon")]
		public string LargeIcon {
			get {
				if (largeIcon_jfieldId == IntPtr.Zero)
					largeIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "largeIcon", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, largeIcon_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (largeIcon_jfieldId == IntPtr.Zero)
					largeIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "largeIcon", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, largeIcon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr msg_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='msg_id']"
		[Register ("msg_id")]
		public string MsgId {
			get {
				if (msg_id_jfieldId == IntPtr.Zero)
					msg_id_jfieldId = JNIEnv.GetFieldID (class_ref, "msg_id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, msg_id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (msg_id_jfieldId == IntPtr.Zero)
					msg_id_jfieldId = JNIEnv.GetFieldID (class_ref, "msg_id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, msg_id_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr play_lights_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='play_lights']"
		[Register ("play_lights")]
		public bool PlayLights {
			get {
				if (play_lights_jfieldId == IntPtr.Zero)
					play_lights_jfieldId = JNIEnv.GetFieldID (class_ref, "play_lights", "Z");
				return JNIEnv.GetBooleanField (Handle, play_lights_jfieldId);
			}
			set {
				if (play_lights_jfieldId == IntPtr.Zero)
					play_lights_jfieldId = JNIEnv.GetFieldID (class_ref, "play_lights", "Z");
				JNIEnv.SetField (Handle, play_lights_jfieldId, value);
			}
		}

		static IntPtr play_sound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='play_sound']"
		[Register ("play_sound")]
		public bool PlaySound {
			get {
				if (play_sound_jfieldId == IntPtr.Zero)
					play_sound_jfieldId = JNIEnv.GetFieldID (class_ref, "play_sound", "Z");
				return JNIEnv.GetBooleanField (Handle, play_sound_jfieldId);
			}
			set {
				if (play_sound_jfieldId == IntPtr.Zero)
					play_sound_jfieldId = JNIEnv.GetFieldID (class_ref, "play_sound", "Z");
				JNIEnv.SetField (Handle, play_sound_jfieldId, value);
			}
		}

		static IntPtr play_vibrate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='play_vibrate']"
		[Register ("play_vibrate")]
		public bool PlayVibrate {
			get {
				if (play_vibrate_jfieldId == IntPtr.Zero)
					play_vibrate_jfieldId = JNIEnv.GetFieldID (class_ref, "play_vibrate", "Z");
				return JNIEnv.GetBooleanField (Handle, play_vibrate_jfieldId);
			}
			set {
				if (play_vibrate_jfieldId == IntPtr.Zero)
					play_vibrate_jfieldId = JNIEnv.GetFieldID (class_ref, "play_vibrate", "Z");
				JNIEnv.SetField (Handle, play_vibrate_jfieldId, value);
			}
		}

		static IntPtr random_min_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='random_min']"
		[Register ("random_min")]
		public long RandomMin {
			get {
				if (random_min_jfieldId == IntPtr.Zero)
					random_min_jfieldId = JNIEnv.GetFieldID (class_ref, "random_min", "J");
				return JNIEnv.GetLongField (Handle, random_min_jfieldId);
			}
			set {
				if (random_min_jfieldId == IntPtr.Zero)
					random_min_jfieldId = JNIEnv.GetFieldID (class_ref, "random_min", "J");
				JNIEnv.SetField (Handle, random_min_jfieldId, value);
			}
		}

		static IntPtr screen_on_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='screen_on']"
		[Register ("screen_on")]
		public bool ScreenOn {
			get {
				if (screen_on_jfieldId == IntPtr.Zero)
					screen_on_jfieldId = JNIEnv.GetFieldID (class_ref, "screen_on", "Z");
				return JNIEnv.GetBooleanField (Handle, screen_on_jfieldId);
			}
			set {
				if (screen_on_jfieldId == IntPtr.Zero)
					screen_on_jfieldId = JNIEnv.GetFieldID (class_ref, "screen_on", "Z");
				JNIEnv.SetField (Handle, screen_on_jfieldId, value);
			}
		}

		static IntPtr sound_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='sound']"
		[Register ("sound")]
		public string Sound {
			get {
				if (sound_jfieldId == IntPtr.Zero)
					sound_jfieldId = JNIEnv.GetFieldID (class_ref, "sound", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sound_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sound_jfieldId == IntPtr.Zero)
					sound_jfieldId = JNIEnv.GetFieldID (class_ref, "sound", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, sound_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr text_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='text']"
		[Register ("text")]
		public string Text {
			get {
				if (text_jfieldId == IntPtr.Zero)
					text_jfieldId = JNIEnv.GetFieldID (class_ref, "text", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, text_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (text_jfieldId == IntPtr.Zero)
					text_jfieldId = JNIEnv.GetFieldID (class_ref, "text", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, text_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ticker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='ticker']"
		[Register ("ticker")]
		public string Ticker {
			get {
				if (ticker_jfieldId == IntPtr.Zero)
					ticker_jfieldId = JNIEnv.GetFieldID (class_ref, "ticker", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ticker_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ticker_jfieldId == IntPtr.Zero)
					ticker_jfieldId = JNIEnv.GetFieldID (class_ref, "ticker", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, ticker_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, title_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, url_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/entity/UMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMessage); }
		}

		protected UMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/constructor[@name='UMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public UMessage (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UMessage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, new JValue (p0));
		}

		static Delegate cb_hasResourceFromInternet;
#pragma warning disable 0169
		static Delegate GetHasResourceFromInternetHandler ()
		{
			if (cb_hasResourceFromInternet == null)
				cb_hasResourceFromInternet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasResourceFromInternet);
			return cb_hasResourceFromInternet;
		}

		static bool n_HasResourceFromInternet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Entity.UMessage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasResourceFromInternet;
		}
#pragma warning restore 0169

		static IntPtr id_hasResourceFromInternet;
		public virtual bool HasResourceFromInternet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/method[@name='hasResourceFromInternet' and count(parameter)=0]"
			[Register ("hasResourceFromInternet", "()Z", "GetHasResourceFromInternetHandler")]
			get {
				if (id_hasResourceFromInternet == IntPtr.Zero)
					id_hasResourceFromInternet = JNIEnv.GetMethodID (class_ref, "hasResourceFromInternet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasResourceFromInternet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasResourceFromInternet", "()Z"));
			}
		}

		static Delegate cb_isLargeIconFromInternet;
#pragma warning disable 0169
		static Delegate GetIsLargeIconFromInternetHandler ()
		{
			if (cb_isLargeIconFromInternet == null)
				cb_isLargeIconFromInternet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLargeIconFromInternet);
			return cb_isLargeIconFromInternet;
		}

		static bool n_IsLargeIconFromInternet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Entity.UMessage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLargeIconFromInternet;
		}
#pragma warning restore 0169

		static IntPtr id_isLargeIconFromInternet;
		public virtual bool IsLargeIconFromInternet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/method[@name='isLargeIconFromInternet' and count(parameter)=0]"
			[Register ("isLargeIconFromInternet", "()Z", "GetIsLargeIconFromInternetHandler")]
			get {
				if (id_isLargeIconFromInternet == IntPtr.Zero)
					id_isLargeIconFromInternet = JNIEnv.GetMethodID (class_ref, "isLargeIconFromInternet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLargeIconFromInternet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLargeIconFromInternet", "()Z"));
			}
		}

		static Delegate cb_isSoundFromInternet;
#pragma warning disable 0169
		static Delegate GetIsSoundFromInternetHandler ()
		{
			if (cb_isSoundFromInternet == null)
				cb_isSoundFromInternet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSoundFromInternet);
			return cb_isSoundFromInternet;
		}

		static bool n_IsSoundFromInternet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Entity.UMessage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSoundFromInternet;
		}
#pragma warning restore 0169

		static IntPtr id_isSoundFromInternet;
		public virtual bool IsSoundFromInternet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/method[@name='isSoundFromInternet' and count(parameter)=0]"
			[Register ("isSoundFromInternet", "()Z", "GetIsSoundFromInternetHandler")]
			get {
				if (id_isSoundFromInternet == IntPtr.Zero)
					id_isSoundFromInternet = JNIEnv.GetMethodID (class_ref, "isSoundFromInternet", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSoundFromInternet);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSoundFromInternet", "()Z"));
			}
		}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRaw);
			return cb_getRaw;
		}

		static IntPtr n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Entity.UMessage __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Raw);
		}
#pragma warning restore 0169

		static IntPtr id_getRaw;
		public virtual global::Org.Json.JSONObject Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.entity']/class[@name='UMessage']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()Lorg/json/JSONObject;", "GetGetRawHandler")]
			get {
				if (id_getRaw == IntPtr.Zero)
					id_getRaw = JNIEnv.GetMethodID (class_ref, "getRaw", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getRaw), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRaw", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
