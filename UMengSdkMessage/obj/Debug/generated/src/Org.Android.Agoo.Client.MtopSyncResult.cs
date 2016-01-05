using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']"
	[global::Android.Runtime.Register ("org/android/agoo/client/MtopSyncResult", DoNotGenerateAcw=true)]
	public sealed partial class MtopSyncResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/MtopSyncResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopSyncResult); }
		}

		internal MtopSyncResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/constructor[@name='MtopSyncResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopSyncResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopSyncResult)) {
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

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_lang_String_;
		public string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setData", "(Ljava/lang/String;)V", "GetSetData_Ljava_lang_String_Handler")]
			set {
				if (id_setData_Ljava_lang_String_ == IntPtr.Zero)
					id_setData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setData_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getRetCode;
		static IntPtr id_setRetCode_Ljava_lang_String_;
		public string RetCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='getRetCode' and count(parameter)=0]"
			[Register ("getRetCode", "()Ljava/lang/String;", "GetGetRetCodeHandler")]
			get {
				if (id_getRetCode == IntPtr.Zero)
					id_getRetCode = JNIEnv.GetMethodID (class_ref, "getRetCode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRetCode), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='setRetCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRetCode", "(Ljava/lang/String;)V", "GetSetRetCode_Ljava_lang_String_Handler")]
			set {
				if (id_setRetCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setRetCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRetCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setRetCode_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getRetDesc;
		static IntPtr id_setRetDesc_Ljava_lang_String_;
		public string RetDesc {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='getRetDesc' and count(parameter)=0]"
			[Register ("getRetDesc", "()Ljava/lang/String;", "GetGetRetDescHandler")]
			get {
				if (id_getRetDesc == IntPtr.Zero)
					id_getRetDesc = JNIEnv.GetMethodID (class_ref, "getRetDesc", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRetDesc), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='setRetDesc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRetDesc", "(Ljava/lang/String;)V", "GetSetRetDesc_Ljava_lang_String_Handler")]
			set {
				if (id_setRetDesc_Ljava_lang_String_ == IntPtr.Zero)
					id_setRetDesc_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRetDesc", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setRetDesc_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isSuccess;
		static IntPtr id_setSuccess_Z;
		public bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSuccess);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='setSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSuccess", "(Z)V", "GetSetSuccess_ZHandler")]
			set {
				if (id_setSuccess_Z == IntPtr.Zero)
					id_setSuccess_Z = JNIEnv.GetMethodID (class_ref, "setSuccess", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setSuccess_Z, new JValue (value));
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopSyncResult']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
