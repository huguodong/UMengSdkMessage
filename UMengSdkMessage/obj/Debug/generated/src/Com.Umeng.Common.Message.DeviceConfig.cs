using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Common.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']"
	[global::Android.Runtime.Register ("com/umeng/common/message/DeviceConfig", DoNotGenerateAcw=true)]
	public partial class DeviceConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/field[@name='DEFAULT_TIMEZONE']"
		[Register ("DEFAULT_TIMEZONE")]
		public const int DefaultTimezone = (int) 8;

		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/field[@name='a']"
		[Register ("a")]
		protected static string A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, a_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/field[@name='b']"
		[Register ("b")]
		protected const string B = (string) "Unknown";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/common/message/DeviceConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceConfig); }
		}

		protected DeviceConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/constructor[@name='DeviceConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceConfig)) {
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

		static IntPtr id_getCPU;
		public static string CPU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getCPU' and count(parameter)=0]"
			[Register ("getCPU", "()Ljava/lang/String;", "GetGetCPUHandler")]
			get {
				if (id_getCPU == IntPtr.Zero)
					id_getCPU = JNIEnv.GetStaticMethodID (class_ref, "getCPU", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCPU), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isSdCardWrittenable;
		public static bool IsSdCardWrittenable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isSdCardWrittenable' and count(parameter)=0]"
			[Register ("isSdCardWrittenable", "()Z", "GetIsSdCardWrittenableHandler")]
			get {
				if (id_isSdCardWrittenable == IntPtr.Zero)
					id_isSdCardWrittenable = JNIEnv.GetStaticMethodID (class_ref, "isSdCardWrittenable", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSdCardWrittenable);
			}
		}

		static IntPtr id_getToday;
		public static string Today {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getToday' and count(parameter)=0]"
			[Register ("getToday", "()Ljava/lang/String;", "GetGetTodayHandler")]
			get {
				if (id_getToday == IntPtr.Zero)
					id_getToday = JNIEnv.GetStaticMethodID (class_ref, "getToday", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToday), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_checkPermission_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='checkPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkPermission", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static bool CheckPermission (global::Android.Content.Context p0, string p1)
		{
			if (id_checkPermission_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_checkPermission_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkPermission", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkPermission_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getAppLabel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getAppLabel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppLabel", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAppLabel (global::Android.Content.Context p0)
		{
			if (id_getAppLabel_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppLabel_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppLabel", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppLabel_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAppVersionCode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getAppVersionCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionCode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAppVersionCode (global::Android.Content.Context p0)
		{
			if (id_getAppVersionCode_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersionCode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersionCode", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersionCode_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAppVersionName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getAppVersionName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAppVersionName (global::Android.Content.Context p0)
		{
			if (id_getAppVersionName_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersionName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersionName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAppkey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getAppkey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppkey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAppkey (global::Android.Content.Context p0)
		{
			if (id_getAppkey_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppkey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppkey", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppkey_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getApplicationLable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getApplicationLable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationLable", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetApplicationLable (global::Android.Content.Context p0)
		{
			if (id_getApplicationLable_Landroid_content_Context_ == IntPtr.Zero)
				id_getApplicationLable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getApplicationLable", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationLable_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getChannel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getChannel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getChannel", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetChannel (global::Android.Content.Context p0)
		{
			if (id_getChannel_Landroid_content_Context_ == IntPtr.Zero)
				id_getChannel_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getChannel", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannel_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getDeviceId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetDeviceId (global::Android.Content.Context p0)
		{
			if (id_getDeviceId_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getDeviceIdMD5_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getDeviceIdMD5' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceIdMD5", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetDeviceIdMD5 (global::Android.Content.Context p0)
		{
			if (id_getDeviceIdMD5_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceIdMD5_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceIdMD5", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceIdMD5_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getDeviceIdUmengMD5_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getDeviceIdUmengMD5' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceIdUmengMD5", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetDeviceIdUmengMD5 (global::Android.Content.Context p0)
		{
			if (id_getDeviceIdUmengMD5_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceIdUmengMD5_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceIdUmengMD5", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceIdUmengMD5_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getDisplayResolution_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getDisplayResolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDisplayResolution", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetDisplayResolution (global::Android.Content.Context p0)
		{
			if (id_getDisplayResolution_Landroid_content_Context_ == IntPtr.Zero)
				id_getDisplayResolution_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDisplayResolution", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDisplayResolution_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getGPU_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getGPU' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("getGPU", "(Ljavax/microedition/khronos/opengles/GL10;)[Ljava/lang/String;", "")]
		public static string[] GetGPU (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
		{
			if (id_getGPU_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_getGPU_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetStaticMethodID (class_ref, "getGPU", "(Ljavax/microedition/khronos/opengles/GL10;)[Ljava/lang/String;");
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGPU_Ljavax_microedition_khronos_opengles_GL10_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static IntPtr id_getInstalledPackages_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getInstalledPackages' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstalledPackages", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> GetInstalledPackages (global::Android.Content.Context p0)
		{
			if (id_getInstalledPackages_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstalledPackages_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstalledPackages", "(Landroid/content/Context;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstalledPackages_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getIntervalSeconds_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getIntervalSeconds' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("getIntervalSeconds", "(Ljava/util/Date;Ljava/util/Date;)I", "")]
		public static int GetIntervalSeconds (global::Java.Util.Date p0, global::Java.Util.Date p1)
		{
			if (id_getIntervalSeconds_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_getIntervalSeconds_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "getIntervalSeconds", "(Ljava/util/Date;Ljava/util/Date;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getIntervalSeconds_Ljava_util_Date_Ljava_util_Date_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_getLocaleInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getLocaleInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocaleInfo", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static string[] GetLocaleInfo (global::Android.Content.Context p0)
		{
			if (id_getLocaleInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocaleInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocaleInfo", "(Landroid/content/Context;)[Ljava/lang/String;");
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocaleInfo_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static IntPtr id_getLocation_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getLocation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocation", "(Landroid/content/Context;)Landroid/location/Location;", "")]
		public static global::Android.Locations.Location GetLocation (global::Android.Content.Context p0)
		{
			if (id_getLocation_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocation_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocation", "(Landroid/content/Context;)Landroid/location/Location;");
			global::Android.Locations.Location __ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocation_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getMac_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getMac' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMac", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetMac (global::Android.Content.Context p0)
		{
			if (id_getMac_Landroid_content_Context_ == IntPtr.Zero)
				id_getMac_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMac", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMac_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getMetaData_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getMetaData' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMetaData", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetMetaData (global::Android.Content.Context p0, string p1)
		{
			if (id_getMetaData_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetaData_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMetaData", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMetaData_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getNetworkAccessMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getNetworkAccessMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static string[] GetNetworkAccessMode (global::Android.Content.Context p0)
		{
			if (id_getNetworkAccessMode_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkAccessMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;");
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkAccessMode_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			return __ret;
		}

		static IntPtr id_getNetworkOperatorName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getNetworkOperatorName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkOperatorName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetNetworkOperatorName (global::Android.Content.Context p0)
		{
			if (id_getNetworkOperatorName_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkOperatorName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkOperatorName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkOperatorName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getOperator_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getOperator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOperator", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetOperator (global::Android.Content.Context p0)
		{
			if (id_getOperator_Landroid_content_Context_ == IntPtr.Zero)
				id_getOperator_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getOperator", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOperator_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getPackageName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getPackageName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPackageName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetPackageName (global::Android.Content.Context p0)
		{
			if (id_getPackageName_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getResolution_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getResolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getResolution", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetResolution (global::Android.Content.Context p0)
		{
			if (id_getResolution_Landroid_content_Context_ == IntPtr.Zero)
				id_getResolution_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getResolution", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResolution_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getTimeString_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getTimeString' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("getTimeString", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static string GetTimeString (global::Java.Util.Date p0)
		{
			if (id_getTimeString_Ljava_util_Date_ == IntPtr.Zero)
				id_getTimeString_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeString", "(Ljava/util/Date;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeString_Ljava_util_Date_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getTimeZone_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getTimeZone' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTimeZone", "(Landroid/content/Context;)I", "")]
		public static int GetTimeZone (global::Android.Content.Context p0)
		{
			if (id_getTimeZone_Landroid_content_Context_ == IntPtr.Zero)
				id_getTimeZone_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeZone", "(Landroid/content/Context;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getTimeZone_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getUtdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='getUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetUtdid (global::Android.Content.Context p0)
		{
			if (id_getUtdid_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUtdid", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUtdid_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isAppInstalled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("isAppInstalled", "(Ljava/lang/String;Landroid/content/Context;)Z", "")]
		public static bool IsAppInstalled (string p0, global::Android.Content.Context p1)
		{
			if (id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isAppInstalled", "(Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isChinese_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isChinese' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isChinese", "(Landroid/content/Context;)Z", "")]
		public static bool IsChinese (global::Android.Content.Context p0)
		{
			if (id_isChinese_Landroid_content_Context_ == IntPtr.Zero)
				id_isChinese_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isChinese", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isChinese_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isDebug_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isDebug' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isDebug", "(Landroid/content/Context;)Z", "")]
		public static bool IsDebug (global::Android.Content.Context p0)
		{
			if (id_isDebug_Landroid_content_Context_ == IntPtr.Zero)
				id_isDebug_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isDebug", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebug_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isOnline_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isOnline' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isOnline", "(Landroid/content/Context;)Z", "")]
		public static bool IsOnline (global::Android.Content.Context p0)
		{
			if (id_isOnline_Landroid_content_Context_ == IntPtr.Zero)
				id_isOnline_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isOnline", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOnline_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isScreenPortrait_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isScreenPortrait' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isScreenPortrait", "(Landroid/content/Context;)Z", "")]
		public static bool IsScreenPortrait (global::Android.Content.Context p0)
		{
			if (id_isScreenPortrait_Landroid_content_Context_ == IntPtr.Zero)
				id_isScreenPortrait_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isScreenPortrait", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isScreenPortrait_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_isWiFiAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='isWiFiAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isWiFiAvailable", "(Landroid/content/Context;)Z", "")]
		public static bool IsWiFiAvailable (global::Android.Content.Context p0)
		{
			if (id_isWiFiAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isWiFiAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isWiFiAvailable", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWiFiAvailable_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_toTime_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.common.message']/class[@name='DeviceConfig']/method[@name='toTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toTime", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static global::Java.Util.Date ToTime (string p0)
		{
			if (id_toTime_Ljava_lang_String_ == IntPtr.Zero)
				id_toTime_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toTime", "(Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Util.Date __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toTime_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
