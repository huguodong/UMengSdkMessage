using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/NetworkUtils", DoNotGenerateAcw=true)]
	public partial class NetworkUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/field[@name='DEFAULT_WIFI_ADDRESS']"
		[Register ("DEFAULT_WIFI_ADDRESS")]
		public const string DefaultWifiAddress = (string) "00-00-00-00-00-00";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/field[@name='WIFI']"
		[Register ("WIFI")]
		public const string Wifi = (string) "Wi-Fi";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/NetworkUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkUtils); }
		}

		protected NetworkUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/constructor[@name='NetworkUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NetworkUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NetworkUtils)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_getConnManager_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='getConnManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnManager", "(Landroid/content/Context;)Landroid/net/ConnectivityManager;", "")]
		public static global::Android.Net.ConnectivityManager GetConnManager (global::Android.Content.Context p0)
		{
			if (id_getConnManager_Landroid_content_Context_ == IntPtr.Zero)
				id_getConnManager_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getConnManager", "(Landroid/content/Context;)Landroid/net/ConnectivityManager;");
			global::Android.Net.ConnectivityManager __ret = global::Java.Lang.Object.GetObject<global::Android.Net.ConnectivityManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConnManager_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getNetworkState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='getNetworkState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkState", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static string[] GetNetworkState (global::Android.Content.Context p0)
		{
			if (id_getNetworkState_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkState", "(Landroid/content/Context;)[Ljava/lang/String;");
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkState_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static IntPtr id_getWifiAddress_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='getWifiAddress' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getWifiAddress", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetWifiAddress (global::Android.Content.Context p0)
		{
			if (id_getWifiAddress_Landroid_content_Context_ == IntPtr.Zero)
				id_getWifiAddress_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getWifiAddress", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWifiAddress_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getWifiIpAddress_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='getWifiIpAddress' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getWifiIpAddress", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetWifiIpAddress (global::Android.Content.Context p0)
		{
			if (id_getWifiIpAddress_Landroid_content_Context_ == IntPtr.Zero)
				id_getWifiIpAddress_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getWifiIpAddress", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWifiIpAddress_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isConnected_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='isConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isConnected", "(Landroid/content/Context;)Z", "")]
		public static bool IsConnected (global::Android.Content.Context p0)
		{
			if (id_isConnected_Landroid_content_Context_ == IntPtr.Zero)
				id_isConnected_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isConnected", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConnected_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isConnectedToWeakNetwork_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='isConnectedToWeakNetwork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isConnectedToWeakNetwork", "(Landroid/content/Context;)Z", "")]
		public static bool IsConnectedToWeakNetwork (global::Android.Content.Context p0)
		{
			if (id_isConnectedToWeakNetwork_Landroid_content_Context_ == IntPtr.Zero)
				id_isConnectedToWeakNetwork_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isConnectedToWeakNetwork", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConnectedToWeakNetwork_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isWifi_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='NetworkUtils']/method[@name='isWifi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isWifi", "(Landroid/content/Context;)Z", "")]
		public static bool IsWifi (global::Android.Content.Context p0)
		{
			if (id_isWifi_Landroid_content_Context_ == IntPtr.Zero)
				id_isWifi_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isWifi", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWifi_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

	}
}
