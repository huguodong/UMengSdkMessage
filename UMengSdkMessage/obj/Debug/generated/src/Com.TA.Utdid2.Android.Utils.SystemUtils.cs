using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/SystemUtils", DoNotGenerateAcw=true)]
	public partial class SystemUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/SystemUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemUtils); }
		}

		protected SystemUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']/constructor[@name='SystemUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SystemUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SystemUtils)) {
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

		static IntPtr id_getCpuInfo;
		public static string CpuInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']/method[@name='getCpuInfo' and count(parameter)=0]"
			[Register ("getCpuInfo", "()Ljava/lang/String;", "GetGetCpuInfoHandler")]
			get {
				if (id_getCpuInfo == IntPtr.Zero)
					id_getCpuInfo = JNIEnv.GetStaticMethodID (class_ref, "getCpuInfo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCpuInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSystemVersion;
		public static int SystemVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']/method[@name='getSystemVersion' and count(parameter)=0]"
			[Register ("getSystemVersion", "()I", "GetGetSystemVersionHandler")]
			get {
				if (id_getSystemVersion == IntPtr.Zero)
					id_getSystemVersion = JNIEnv.GetStaticMethodID (class_ref, "getSystemVersion", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getSystemVersion);
			}
		}

		static IntPtr id_getAppLabel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']/method[@name='getAppLabel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppLabel", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAppLabel (global::Android.Content.Context p0)
		{
			if (id_getAppLabel_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppLabel_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppLabel", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppLabel_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRootFolder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='SystemUtils']/method[@name='getRootFolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRootFolder", "(Ljava/lang/String;)Ljava/io/File;", "")]
		public static global::Java.IO.File GetRootFolder (string p0)
		{
			if (id_getRootFolder_Ljava_lang_String_ == IntPtr.Zero)
				id_getRootFolder_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRootFolder", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRootFolder_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
