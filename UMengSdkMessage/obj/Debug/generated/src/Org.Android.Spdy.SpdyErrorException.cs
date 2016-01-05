using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyErrorException", DoNotGenerateAcw=true)]
	public partial class SpdyErrorException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyErrorException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyErrorException); }
		}

		protected SpdyErrorException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']/constructor[@name='SpdyErrorException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public SpdyErrorException (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpdyErrorException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']/constructor[@name='SpdyErrorException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public SpdyErrorException (string p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (SpdyErrorException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']/constructor[@name='SpdyErrorException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;I)V", "")]
		public SpdyErrorException (string p0, global::Java.Lang.Throwable p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (SpdyErrorException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;I)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Throwable;I)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']/constructor[@name='SpdyErrorException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/Throwable;I)V", "")]
		public SpdyErrorException (global::Java.Lang.Throwable p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpdyErrorException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_lang_Throwable_I == IntPtr.Zero)
				id_ctor_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_I, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_SpdyErrorGetCode;
#pragma warning disable 0169
		static Delegate GetSpdyErrorGetCodeHandler ()
		{
			if (cb_SpdyErrorGetCode == null)
				cb_SpdyErrorGetCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SpdyErrorGetCode);
			return cb_SpdyErrorGetCode;
		}

		static int n_SpdyErrorGetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Spdy.SpdyErrorException __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyErrorException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpdyErrorGetCode ();
		}
#pragma warning restore 0169

		static IntPtr id_SpdyErrorGetCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyErrorException']/method[@name='SpdyErrorGetCode' and count(parameter)=0]"
		[Register ("SpdyErrorGetCode", "()I", "GetSpdyErrorGetCodeHandler")]
		public virtual int SpdyErrorGetCode ()
		{
			if (id_SpdyErrorGetCode == IntPtr.Zero)
				id_SpdyErrorGetCode = JNIEnv.GetMethodID (class_ref, "SpdyErrorGetCode", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_SpdyErrorGetCode);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SpdyErrorGetCode", "()I"));
		}

	}
}
