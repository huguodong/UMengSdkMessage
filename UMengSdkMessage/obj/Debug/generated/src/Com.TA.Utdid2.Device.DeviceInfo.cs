using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='DeviceInfo']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/DeviceInfo", DoNotGenerateAcw=true)]
	public partial class DeviceInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/DeviceInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceInfo); }
		}

		protected DeviceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='DeviceInfo']/constructor[@name='DeviceInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DeviceInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DeviceInfo)) {
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

		static IntPtr id_getDevice_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='DeviceInfo']/method[@name='getDevice' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDevice", "(Landroid/content/Context;)Lcom/ta/utdid2/device/Device;", "")]
		public static global::Com.TA.Utdid2.Device.Device GetDevice (global::Android.Content.Context p0)
		{
			if (id_getDevice_Landroid_content_Context_ == IntPtr.Zero)
				id_getDevice_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDevice", "(Landroid/content/Context;)Lcom/ta/utdid2/device/Device;");
			global::Com.TA.Utdid2.Device.Device __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.Device> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDevice_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
