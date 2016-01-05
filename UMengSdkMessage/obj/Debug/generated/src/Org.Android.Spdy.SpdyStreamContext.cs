using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyStreamContext", DoNotGenerateAcw=true)]
	public partial class SpdyStreamContext : global::Java.Lang.Object {


		static IntPtr callBack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']/field[@name='callBack']"
		[Register ("callBack")]
		public global::Org.Android.Spdy.ISpdycb CallBack {
			get {
				if (callBack_jfieldId == IntPtr.Zero)
					callBack_jfieldId = JNIEnv.GetFieldID (class_ref, "callBack", "Lorg/android/spdy/Spdycb;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, callBack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (callBack_jfieldId == IntPtr.Zero)
					callBack_jfieldId = JNIEnv.GetFieldID (class_ref, "callBack", "Lorg/android/spdy/Spdycb;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, callBack_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr streamContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyStreamContext']/field[@name='streamContext']"
		[Register ("streamContext")]
		public global::Java.Lang.Object StreamContext {
			get {
				if (streamContext_jfieldId == IntPtr.Zero)
					streamContext_jfieldId = JNIEnv.GetFieldID (class_ref, "streamContext", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, streamContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (streamContext_jfieldId == IntPtr.Zero)
					streamContext_jfieldId = JNIEnv.GetFieldID (class_ref, "streamContext", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, streamContext_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyStreamContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyStreamContext); }
		}

		protected SpdyStreamContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
