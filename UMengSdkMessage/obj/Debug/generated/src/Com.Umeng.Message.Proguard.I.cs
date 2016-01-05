using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='I']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/I", DoNotGenerateAcw=true)]
	public partial class I : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='I']/field[@name='b']"
		[Register ("b")]
		protected global::System.Collections.IDictionary B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, b_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/I", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (I); }
		}

		protected I (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='I']/constructor[@name='I' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public I () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (I)) {
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

		static Delegate cb_a_II;
#pragma warning disable 0169
		static Delegate GetA_IIHandler ()
		{
			if (cb_a_II == null)
				cb_a_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_A_II);
			return cb_a_II;
		}

		static void n_A_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Umeng.Message.Proguard.I __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.I> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='I']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("a", "(II)V", "GetA_IIHandler")]
		public virtual void A (int p0, int p1)
		{
			if (id_a_II == IntPtr.Zero)
				id_a_II = JNIEnv.GetMethodID (class_ref, "a", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_a_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(II)V"), new JValue (p0), new JValue (p1));
		}

	}
}
