using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']"
	[global::Android.Runtime.Register ("com/google/protobuf/TextFormat", DoNotGenerateAcw=true)]
	public sealed partial class TextFormat : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat.ParseException']"
		[global::Android.Runtime.Register ("com/google/protobuf/TextFormat$ParseException", DoNotGenerateAcw=true)]
		public partial class ParseException : global::Java.IO.IOException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/protobuf/TextFormat$ParseException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ParseException); }
			}

			protected ParseException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat.ParseException']/constructor[@name='TextFormat.ParseException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public ParseException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);;
				if (GetType () != typeof (ParseException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static IntPtr id_ctor_IILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat.ParseException']/constructor[@name='TextFormat.ParseException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(IILjava/lang/String;)V", "")]
			public ParseException (int p0, int p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (ParseException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILjava/lang/String;)V", new JValue (p0), new JValue (p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_IILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_getColumn;
#pragma warning disable 0169
			static Delegate GetGetColumnHandler ()
			{
				if (cb_getColumn == null)
					cb_getColumn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColumn);
				return cb_getColumn;
			}

			static int n_GetColumn (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.TextFormat.ParseException __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.TextFormat.ParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Column;
			}
#pragma warning restore 0169

			static IntPtr id_getColumn;
			public virtual int Column {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat.ParseException']/method[@name='getColumn' and count(parameter)=0]"
				[Register ("getColumn", "()I", "GetGetColumnHandler")]
				get {
					if (id_getColumn == IntPtr.Zero)
						id_getColumn = JNIEnv.GetMethodID (class_ref, "getColumn", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getColumn);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColumn", "()I"));
				}
			}

			static Delegate cb_getLine;
#pragma warning disable 0169
			static Delegate GetGetLineHandler ()
			{
				if (cb_getLine == null)
					cb_getLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLine);
				return cb_getLine;
			}

			static int n_GetLine (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Protobuf.TextFormat.ParseException __this = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.TextFormat.ParseException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Line;
			}
#pragma warning restore 0169

			static IntPtr id_getLine;
			public virtual int Line {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat.ParseException']/method[@name='getLine' and count(parameter)=0]"
				[Register ("getLine", "()I", "GetGetLineHandler")]
				get {
					if (id_getLine == IntPtr.Zero)
						id_getLine = JNIEnv.GetMethodID (class_ref, "getLine", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLine);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLine", "()I"));
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/TextFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextFormat); }
		}

		internal TextFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_print_Lcom_google_protobuf_UnknownFieldSet_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']/method[@name='print' and count(parameter)=2 and parameter[1][@type='com.google.protobuf.UnknownFieldSet'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("print", "(Lcom/google/protobuf/UnknownFieldSet;Ljava/lang/Appendable;)V", "")]
		public static void Print (global::Com.Google.Protobuf.UnknownFieldSet p0, global::Java.Lang.IAppendable p1)
		{
			if (id_print_Lcom_google_protobuf_UnknownFieldSet_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_print_Lcom_google_protobuf_UnknownFieldSet_Ljava_lang_Appendable_ = JNIEnv.GetStaticMethodID (class_ref, "print", "(Lcom/google/protobuf/UnknownFieldSet;Ljava/lang/Appendable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_print_Lcom_google_protobuf_UnknownFieldSet_Ljava_lang_Appendable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_printToString_Lcom_google_protobuf_UnknownFieldSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']/method[@name='printToString' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
		[Register ("printToString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;", "")]
		public static string PrintToString (global::Com.Google.Protobuf.UnknownFieldSet p0)
		{
			if (id_printToString_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
				id_printToString_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetStaticMethodID (class_ref, "printToString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_printToString_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_printToUnicodeString_Lcom_google_protobuf_UnknownFieldSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']/method[@name='printToUnicodeString' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
		[Register ("printToUnicodeString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;", "")]
		public static string PrintToUnicodeString (global::Com.Google.Protobuf.UnknownFieldSet p0)
		{
			if (id_printToUnicodeString_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
				id_printToUnicodeString_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetStaticMethodID (class_ref, "printToUnicodeString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_printToUnicodeString_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_printUnknownFieldValue_ILjava_lang_Object_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']/method[@name='printUnknownFieldValue' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Appendable']]"
		[Register ("printUnknownFieldValue", "(ILjava/lang/Object;Ljava/lang/Appendable;)V", "")]
		public static void PrintUnknownFieldValue (int p0, global::Java.Lang.Object p1, global::Java.Lang.IAppendable p2)
		{
			if (id_printUnknownFieldValue_ILjava_lang_Object_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_printUnknownFieldValue_ILjava_lang_Object_Ljava_lang_Appendable_ = JNIEnv.GetStaticMethodID (class_ref, "printUnknownFieldValue", "(ILjava/lang/Object;Ljava/lang/Appendable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_printUnknownFieldValue_ILjava_lang_Object_Ljava_lang_Appendable_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_shortDebugString_Lcom_google_protobuf_UnknownFieldSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='TextFormat']/method[@name='shortDebugString' and count(parameter)=1 and parameter[1][@type='com.google.protobuf.UnknownFieldSet']]"
		[Register ("shortDebugString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;", "")]
		public static string ShortDebugString (global::Com.Google.Protobuf.UnknownFieldSet p0)
		{
			if (id_shortDebugString_Lcom_google_protobuf_UnknownFieldSet_ == IntPtr.Zero)
				id_shortDebugString_Lcom_google_protobuf_UnknownFieldSet_ = JNIEnv.GetStaticMethodID (class_ref, "shortDebugString", "(Lcom/google/protobuf/UnknownFieldSet;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shortDebugString_Lcom_google_protobuf_UnknownFieldSet_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
