using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']"
	[Register ("com/umeng/message/proguard/aL", "", "Com.Umeng.Message.Proguard.IALInvoker")]
	public partial interface IAL : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("a", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetA_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void A (string p0, params global:: Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void A (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void A (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)V", "GetB_Ljava_lang_String_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void B (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='b' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetB_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void B (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/String;)V", "GetC_Ljava_lang_String_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void C (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='c' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetC_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void C (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void D (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void D (string p0, string p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void E (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aL']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Umeng.Message.Proguard.IALInvoker, UMengSdkMessage")]
		void E (string p0, string p1, global::Java.Lang.Throwable p2);

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/aL", DoNotGenerateAcw=true)]
	internal class IALInvoker : global::Java.Lang.Object, IAL {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/proguard/aL");
		IntPtr class_ref;

		public static IAL GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAL> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.proguard.aL"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IALInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IALInvoker); }
		}

		static Delegate cb_a_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_a_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_a_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_a_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_A_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.A (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_String_arrayLjava_lang_Object_;
		public void A (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_a_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_a_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		public void A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_A_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public void A (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_b_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_String_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_B_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_b_Ljava_lang_String_Ljava_lang_String_;
		public void B (string p0, string p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_b_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_B_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_B_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.B (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public void B (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_b_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_c_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_c_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_c_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_C_Ljava_lang_String_Ljava_lang_String_);
			return cb_c_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_C_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.C (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_c_Ljava_lang_String_Ljava_lang_String_;
		public void C (string p0, string p1)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_c_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_C_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_C_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.C (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public void C (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_c_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		public void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_d_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public void D (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		public void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_e_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Message.Proguard.IAL __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		public void E (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
