using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='F']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/F", DoNotGenerateAcw=true)]
	public partial class F : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/F", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (F); }
		}

		protected F (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='F']/constructor[@name='F' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public F (global::Org.Json.JSONObject p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (F)) {
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

		static Delegate cb_a_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_util_Map_Handler ()
		{
			if (cb_a_Ljava_util_Map_ == null)
				cb_a_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_util_Map_);
			return cb_a_Ljava_util_Map_;
		}

		static IntPtr n_A_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.F __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.F> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='F']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("a", "(Ljava/util/Map;)Lcom/umeng/message/proguard/J;", "GetA_Ljava_util_Map_Handler")]
		public virtual global::Com.Umeng.Message.Proguard.J A (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_a_Ljava_util_Map_ == IntPtr.Zero)
				id_a_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/util/Map;)Lcom/umeng/message/proguard/J;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);

			global::Com.Umeng.Message.Proguard.J __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.J> (JNIEnv.CallObjectMethod  (Handle, id_a_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.J> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/util/Map;)Lcom/umeng/message/proguard/J;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
