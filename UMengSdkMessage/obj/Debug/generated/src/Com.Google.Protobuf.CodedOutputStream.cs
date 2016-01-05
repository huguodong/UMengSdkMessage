using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']"
	[global::Android.Runtime.Register ("com/google/protobuf/CodedOutputStream", DoNotGenerateAcw=true)]
	public sealed partial class CodedOutputStream : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/field[@name='DEFAULT_BUFFER_SIZE']"
		[Register ("DEFAULT_BUFFER_SIZE")]
		public const int DefaultBufferSize = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/field[@name='LITTLE_ENDIAN_32_SIZE']"
		[Register ("LITTLE_ENDIAN_32_SIZE")]
		public const int LittleEndian32Size = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/field[@name='LITTLE_ENDIAN_64_SIZE']"
		[Register ("LITTLE_ENDIAN_64_SIZE")]
		public const int LittleEndian64Size = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream.OutOfSpaceException']"
		[global::Android.Runtime.Register ("com/google/protobuf/CodedOutputStream$OutOfSpaceException", DoNotGenerateAcw=true)]
		public partial class OutOfSpaceException : global::Java.IO.IOException {

			protected OutOfSpaceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/CodedOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodedOutputStream); }
		}

		internal CodedOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkNoSpaceLeft;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='checkNoSpaceLeft' and count(parameter)=0]"
		[Register ("checkNoSpaceLeft", "()V", "")]
		public void CheckNoSpaceLeft ()
		{
			if (id_checkNoSpaceLeft == IntPtr.Zero)
				id_checkNoSpaceLeft = JNIEnv.GetMethodID (class_ref, "checkNoSpaceLeft", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_checkNoSpaceLeft);
		}

		static IntPtr id_computeBoolSize_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeBoolSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("computeBoolSize", "(IZ)I", "")]
		public static int ComputeBoolSize (int p0, bool p1)
		{
			if (id_computeBoolSize_IZ == IntPtr.Zero)
				id_computeBoolSize_IZ = JNIEnv.GetStaticMethodID (class_ref, "computeBoolSize", "(IZ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeBoolSize_IZ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeBoolSizeNoTag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeBoolSizeNoTag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("computeBoolSizeNoTag", "(Z)I", "")]
		public static int ComputeBoolSizeNoTag (bool p0)
		{
			if (id_computeBoolSizeNoTag_Z == IntPtr.Zero)
				id_computeBoolSizeNoTag_Z = JNIEnv.GetStaticMethodID (class_ref, "computeBoolSizeNoTag", "(Z)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeBoolSizeNoTag_Z, new JValue (p0));
		}

		static IntPtr id_computeDoubleSize_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeDoubleSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("computeDoubleSize", "(ID)I", "")]
		public static int ComputeDoubleSize (int p0, double p1)
		{
			if (id_computeDoubleSize_ID == IntPtr.Zero)
				id_computeDoubleSize_ID = JNIEnv.GetStaticMethodID (class_ref, "computeDoubleSize", "(ID)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeDoubleSize_ID, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeDoubleSizeNoTag_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeDoubleSizeNoTag' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("computeDoubleSizeNoTag", "(D)I", "")]
		public static int ComputeDoubleSizeNoTag (double p0)
		{
			if (id_computeDoubleSizeNoTag_D == IntPtr.Zero)
				id_computeDoubleSizeNoTag_D = JNIEnv.GetStaticMethodID (class_ref, "computeDoubleSizeNoTag", "(D)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeDoubleSizeNoTag_D, new JValue (p0));
		}

		static IntPtr id_computeEnumSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeEnumSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeEnumSize", "(II)I", "")]
		public static int ComputeEnumSize (int p0, int p1)
		{
			if (id_computeEnumSize_II == IntPtr.Zero)
				id_computeEnumSize_II = JNIEnv.GetStaticMethodID (class_ref, "computeEnumSize", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeEnumSize_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeEnumSizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeEnumSizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeEnumSizeNoTag", "(I)I", "")]
		public static int ComputeEnumSizeNoTag (int p0)
		{
			if (id_computeEnumSizeNoTag_I == IntPtr.Zero)
				id_computeEnumSizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeEnumSizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeEnumSizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeFixed32Size_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFixed32Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeFixed32Size", "(II)I", "")]
		public static int ComputeFixed32Size (int p0, int p1)
		{
			if (id_computeFixed32Size_II == IntPtr.Zero)
				id_computeFixed32Size_II = JNIEnv.GetStaticMethodID (class_ref, "computeFixed32Size", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFixed32Size_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeFixed32SizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFixed32SizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeFixed32SizeNoTag", "(I)I", "")]
		public static int ComputeFixed32SizeNoTag (int p0)
		{
			if (id_computeFixed32SizeNoTag_I == IntPtr.Zero)
				id_computeFixed32SizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeFixed32SizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFixed32SizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeFixed64Size_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFixed64Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("computeFixed64Size", "(IJ)I", "")]
		public static int ComputeFixed64Size (int p0, long p1)
		{
			if (id_computeFixed64Size_IJ == IntPtr.Zero)
				id_computeFixed64Size_IJ = JNIEnv.GetStaticMethodID (class_ref, "computeFixed64Size", "(IJ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFixed64Size_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeFixed64SizeNoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFixed64SizeNoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeFixed64SizeNoTag", "(J)I", "")]
		public static int ComputeFixed64SizeNoTag (long p0)
		{
			if (id_computeFixed64SizeNoTag_J == IntPtr.Zero)
				id_computeFixed64SizeNoTag_J = JNIEnv.GetStaticMethodID (class_ref, "computeFixed64SizeNoTag", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFixed64SizeNoTag_J, new JValue (p0));
		}

		static IntPtr id_computeFloatSize_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFloatSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("computeFloatSize", "(IF)I", "")]
		public static int ComputeFloatSize (int p0, float p1)
		{
			if (id_computeFloatSize_IF == IntPtr.Zero)
				id_computeFloatSize_IF = JNIEnv.GetStaticMethodID (class_ref, "computeFloatSize", "(IF)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFloatSize_IF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeFloatSizeNoTag_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeFloatSizeNoTag' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("computeFloatSizeNoTag", "(F)I", "")]
		public static int ComputeFloatSizeNoTag (float p0)
		{
			if (id_computeFloatSizeNoTag_F == IntPtr.Zero)
				id_computeFloatSizeNoTag_F = JNIEnv.GetStaticMethodID (class_ref, "computeFloatSizeNoTag", "(F)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeFloatSizeNoTag_F, new JValue (p0));
		}

		static IntPtr id_computeInt32Size_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeInt32Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeInt32Size", "(II)I", "")]
		public static int ComputeInt32Size (int p0, int p1)
		{
			if (id_computeInt32Size_II == IntPtr.Zero)
				id_computeInt32Size_II = JNIEnv.GetStaticMethodID (class_ref, "computeInt32Size", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeInt32Size_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeInt32SizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeInt32SizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeInt32SizeNoTag", "(I)I", "")]
		public static int ComputeInt32SizeNoTag (int p0)
		{
			if (id_computeInt32SizeNoTag_I == IntPtr.Zero)
				id_computeInt32SizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeInt32SizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeInt32SizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeInt64Size_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeInt64Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("computeInt64Size", "(IJ)I", "")]
		public static int ComputeInt64Size (int p0, long p1)
		{
			if (id_computeInt64Size_IJ == IntPtr.Zero)
				id_computeInt64Size_IJ = JNIEnv.GetStaticMethodID (class_ref, "computeInt64Size", "(IJ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeInt64Size_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeInt64SizeNoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeInt64SizeNoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeInt64SizeNoTag", "(J)I", "")]
		public static int ComputeInt64SizeNoTag (long p0)
		{
			if (id_computeInt64SizeNoTag_J == IntPtr.Zero)
				id_computeInt64SizeNoTag_J = JNIEnv.GetStaticMethodID (class_ref, "computeInt64SizeNoTag", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeInt64SizeNoTag_J, new JValue (p0));
		}

		static IntPtr id_computeRawVarint32Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeRawVarint32Size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeRawVarint32Size", "(I)I", "")]
		public static int ComputeRawVarint32Size (int p0)
		{
			if (id_computeRawVarint32Size_I == IntPtr.Zero)
				id_computeRawVarint32Size_I = JNIEnv.GetStaticMethodID (class_ref, "computeRawVarint32Size", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeRawVarint32Size_I, new JValue (p0));
		}

		static IntPtr id_computeRawVarint64Size_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeRawVarint64Size' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeRawVarint64Size", "(J)I", "")]
		public static int ComputeRawVarint64Size (long p0)
		{
			if (id_computeRawVarint64Size_J == IntPtr.Zero)
				id_computeRawVarint64Size_J = JNIEnv.GetStaticMethodID (class_ref, "computeRawVarint64Size", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeRawVarint64Size_J, new JValue (p0));
		}

		static IntPtr id_computeSFixed32Size_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSFixed32Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeSFixed32Size", "(II)I", "")]
		public static int ComputeSFixed32Size (int p0, int p1)
		{
			if (id_computeSFixed32Size_II == IntPtr.Zero)
				id_computeSFixed32Size_II = JNIEnv.GetStaticMethodID (class_ref, "computeSFixed32Size", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSFixed32Size_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeSFixed32SizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSFixed32SizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeSFixed32SizeNoTag", "(I)I", "")]
		public static int ComputeSFixed32SizeNoTag (int p0)
		{
			if (id_computeSFixed32SizeNoTag_I == IntPtr.Zero)
				id_computeSFixed32SizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeSFixed32SizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSFixed32SizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeSFixed64Size_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSFixed64Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("computeSFixed64Size", "(IJ)I", "")]
		public static int ComputeSFixed64Size (int p0, long p1)
		{
			if (id_computeSFixed64Size_IJ == IntPtr.Zero)
				id_computeSFixed64Size_IJ = JNIEnv.GetStaticMethodID (class_ref, "computeSFixed64Size", "(IJ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSFixed64Size_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeSFixed64SizeNoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSFixed64SizeNoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeSFixed64SizeNoTag", "(J)I", "")]
		public static int ComputeSFixed64SizeNoTag (long p0)
		{
			if (id_computeSFixed64SizeNoTag_J == IntPtr.Zero)
				id_computeSFixed64SizeNoTag_J = JNIEnv.GetStaticMethodID (class_ref, "computeSFixed64SizeNoTag", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSFixed64SizeNoTag_J, new JValue (p0));
		}

		static IntPtr id_computeSInt32Size_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSInt32Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeSInt32Size", "(II)I", "")]
		public static int ComputeSInt32Size (int p0, int p1)
		{
			if (id_computeSInt32Size_II == IntPtr.Zero)
				id_computeSInt32Size_II = JNIEnv.GetStaticMethodID (class_ref, "computeSInt32Size", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSInt32Size_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeSInt32SizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSInt32SizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeSInt32SizeNoTag", "(I)I", "")]
		public static int ComputeSInt32SizeNoTag (int p0)
		{
			if (id_computeSInt32SizeNoTag_I == IntPtr.Zero)
				id_computeSInt32SizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeSInt32SizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSInt32SizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeSInt64Size_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSInt64Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("computeSInt64Size", "(IJ)I", "")]
		public static int ComputeSInt64Size (int p0, long p1)
		{
			if (id_computeSInt64Size_IJ == IntPtr.Zero)
				id_computeSInt64Size_IJ = JNIEnv.GetStaticMethodID (class_ref, "computeSInt64Size", "(IJ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSInt64Size_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeSInt64SizeNoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeSInt64SizeNoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeSInt64SizeNoTag", "(J)I", "")]
		public static int ComputeSInt64SizeNoTag (long p0)
		{
			if (id_computeSInt64SizeNoTag_J == IntPtr.Zero)
				id_computeSInt64SizeNoTag_J = JNIEnv.GetStaticMethodID (class_ref, "computeSInt64SizeNoTag", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeSInt64SizeNoTag_J, new JValue (p0));
		}

		static IntPtr id_computeStringSize_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeStringSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("computeStringSize", "(ILjava/lang/String;)I", "")]
		public static int ComputeStringSize (int p0, string p1)
		{
			if (id_computeStringSize_ILjava_lang_String_ == IntPtr.Zero)
				id_computeStringSize_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "computeStringSize", "(ILjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeStringSize_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_computeStringSizeNoTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeStringSizeNoTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("computeStringSizeNoTag", "(Ljava/lang/String;)I", "")]
		public static int ComputeStringSizeNoTag (string p0)
		{
			if (id_computeStringSizeNoTag_Ljava_lang_String_ == IntPtr.Zero)
				id_computeStringSizeNoTag_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "computeStringSizeNoTag", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_computeStringSizeNoTag_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_computeTagSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeTagSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeTagSize", "(I)I", "")]
		public static int ComputeTagSize (int p0)
		{
			if (id_computeTagSize_I == IntPtr.Zero)
				id_computeTagSize_I = JNIEnv.GetStaticMethodID (class_ref, "computeTagSize", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeTagSize_I, new JValue (p0));
		}

		static IntPtr id_computeUInt32Size_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeUInt32Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("computeUInt32Size", "(II)I", "")]
		public static int ComputeUInt32Size (int p0, int p1)
		{
			if (id_computeUInt32Size_II == IntPtr.Zero)
				id_computeUInt32Size_II = JNIEnv.GetStaticMethodID (class_ref, "computeUInt32Size", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeUInt32Size_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeUInt32SizeNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeUInt32SizeNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("computeUInt32SizeNoTag", "(I)I", "")]
		public static int ComputeUInt32SizeNoTag (int p0)
		{
			if (id_computeUInt32SizeNoTag_I == IntPtr.Zero)
				id_computeUInt32SizeNoTag_I = JNIEnv.GetStaticMethodID (class_ref, "computeUInt32SizeNoTag", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeUInt32SizeNoTag_I, new JValue (p0));
		}

		static IntPtr id_computeUInt64Size_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeUInt64Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("computeUInt64Size", "(IJ)I", "")]
		public static int ComputeUInt64Size (int p0, long p1)
		{
			if (id_computeUInt64Size_IJ == IntPtr.Zero)
				id_computeUInt64Size_IJ = JNIEnv.GetStaticMethodID (class_ref, "computeUInt64Size", "(IJ)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeUInt64Size_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_computeUInt64SizeNoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='computeUInt64SizeNoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("computeUInt64SizeNoTag", "(J)I", "")]
		public static int ComputeUInt64SizeNoTag (long p0)
		{
			if (id_computeUInt64SizeNoTag_J == IntPtr.Zero)
				id_computeUInt64SizeNoTag_J = JNIEnv.GetStaticMethodID (class_ref, "computeUInt64SizeNoTag", "(J)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_computeUInt64SizeNoTag_J, new JValue (p0));
		}

		static IntPtr id_encodeZigZag32_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='encodeZigZag32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodeZigZag32", "(I)I", "")]
		public static int EncodeZigZag32 (int p0)
		{
			if (id_encodeZigZag32_I == IntPtr.Zero)
				id_encodeZigZag32_I = JNIEnv.GetStaticMethodID (class_ref, "encodeZigZag32", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_encodeZigZag32_I, new JValue (p0));
		}

		static IntPtr id_encodeZigZag64_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='encodeZigZag64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("encodeZigZag64", "(J)J", "")]
		public static long EncodeZigZag64 (long p0)
		{
			if (id_encodeZigZag64_J == IntPtr.Zero)
				id_encodeZigZag64_J = JNIEnv.GetStaticMethodID (class_ref, "encodeZigZag64", "(J)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_encodeZigZag64_J, new JValue (p0));
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_flush);
		}

		static IntPtr id_newInstance_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newInstance", "([B)Lcom/google/protobuf/CodedOutputStream;", "")]
		public static global::Com.Google.Protobuf.CodedOutputStream NewInstance (byte[] p0)
		{
			if (id_newInstance_arrayB == IntPtr.Zero)
				id_newInstance_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([B)Lcom/google/protobuf/CodedOutputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedOutputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("newInstance", "([BII)Lcom/google/protobuf/CodedOutputStream;", "")]
		public static global::Com.Google.Protobuf.CodedOutputStream NewInstance (byte[] p0, int p1, int p2)
		{
			if (id_newInstance_arrayBII == IntPtr.Zero)
				id_newInstance_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([BII)Lcom/google/protobuf/CodedOutputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedOutputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("newInstance", "(Ljava/io/OutputStream;)Lcom/google/protobuf/CodedOutputStream;", "")]
		public static global::Com.Google.Protobuf.CodedOutputStream NewInstance (global::System.IO.Stream p0)
		{
			if (id_newInstance_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_newInstance_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/io/OutputStream;)Lcom/google/protobuf/CodedOutputStream;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.CodedOutputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_io_OutputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newInstance_Ljava_io_OutputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("newInstance", "(Ljava/io/OutputStream;I)Lcom/google/protobuf/CodedOutputStream;", "")]
		public static global::Com.Google.Protobuf.CodedOutputStream NewInstance (global::System.IO.Stream p0, int p1)
		{
			if (id_newInstance_Ljava_io_OutputStream_I == IntPtr.Zero)
				id_newInstance_Ljava_io_OutputStream_I = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/io/OutputStream;I)Lcom/google/protobuf/CodedOutputStream;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.CodedOutputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedOutputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_io_OutputStream_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_spaceLeft;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='spaceLeft' and count(parameter)=0]"
		[Register ("spaceLeft", "()I", "")]
		public int SpaceLeft ()
		{
			if (id_spaceLeft == IntPtr.Zero)
				id_spaceLeft = JNIEnv.GetMethodID (class_ref, "spaceLeft", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_spaceLeft);
		}

		static IntPtr id_writeBool_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeBool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("writeBool", "(IZ)V", "")]
		public void WriteBool (int p0, bool p1)
		{
			if (id_writeBool_IZ == IntPtr.Zero)
				id_writeBool_IZ = JNIEnv.GetMethodID (class_ref, "writeBool", "(IZ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeBool_IZ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeBoolNoTag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeBoolNoTag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("writeBoolNoTag", "(Z)V", "")]
		public void WriteBoolNoTag (bool p0)
		{
			if (id_writeBoolNoTag_Z == IntPtr.Zero)
				id_writeBoolNoTag_Z = JNIEnv.GetMethodID (class_ref, "writeBoolNoTag", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeBoolNoTag_Z, new JValue (p0));
		}

		static IntPtr id_writeDouble_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeDouble' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("writeDouble", "(ID)V", "")]
		public void WriteDouble (int p0, double p1)
		{
			if (id_writeDouble_ID == IntPtr.Zero)
				id_writeDouble_ID = JNIEnv.GetMethodID (class_ref, "writeDouble", "(ID)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeDouble_ID, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeDoubleNoTag_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeDoubleNoTag' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("writeDoubleNoTag", "(D)V", "")]
		public void WriteDoubleNoTag (double p0)
		{
			if (id_writeDoubleNoTag_D == IntPtr.Zero)
				id_writeDoubleNoTag_D = JNIEnv.GetMethodID (class_ref, "writeDoubleNoTag", "(D)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeDoubleNoTag_D, new JValue (p0));
		}

		static IntPtr id_writeEnum_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeEnum' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeEnum", "(II)V", "")]
		public void WriteEnum (int p0, int p1)
		{
			if (id_writeEnum_II == IntPtr.Zero)
				id_writeEnum_II = JNIEnv.GetMethodID (class_ref, "writeEnum", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeEnum_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeEnumNoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeEnumNoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeEnumNoTag", "(I)V", "")]
		public void WriteEnumNoTag (int p0)
		{
			if (id_writeEnumNoTag_I == IntPtr.Zero)
				id_writeEnumNoTag_I = JNIEnv.GetMethodID (class_ref, "writeEnumNoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeEnumNoTag_I, new JValue (p0));
		}

		static IntPtr id_writeFixed32_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFixed32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeFixed32", "(II)V", "")]
		public void WriteFixed32 (int p0, int p1)
		{
			if (id_writeFixed32_II == IntPtr.Zero)
				id_writeFixed32_II = JNIEnv.GetMethodID (class_ref, "writeFixed32", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFixed32_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeFixed32NoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFixed32NoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeFixed32NoTag", "(I)V", "")]
		public void WriteFixed32NoTag (int p0)
		{
			if (id_writeFixed32NoTag_I == IntPtr.Zero)
				id_writeFixed32NoTag_I = JNIEnv.GetMethodID (class_ref, "writeFixed32NoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFixed32NoTag_I, new JValue (p0));
		}

		static IntPtr id_writeFixed64_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFixed64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("writeFixed64", "(IJ)V", "")]
		public void WriteFixed64 (int p0, long p1)
		{
			if (id_writeFixed64_IJ == IntPtr.Zero)
				id_writeFixed64_IJ = JNIEnv.GetMethodID (class_ref, "writeFixed64", "(IJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFixed64_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeFixed64NoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFixed64NoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeFixed64NoTag", "(J)V", "")]
		public void WriteFixed64NoTag (long p0)
		{
			if (id_writeFixed64NoTag_J == IntPtr.Zero)
				id_writeFixed64NoTag_J = JNIEnv.GetMethodID (class_ref, "writeFixed64NoTag", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFixed64NoTag_J, new JValue (p0));
		}

		static IntPtr id_writeFloat_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFloat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("writeFloat", "(IF)V", "")]
		public void WriteFloat (int p0, float p1)
		{
			if (id_writeFloat_IF == IntPtr.Zero)
				id_writeFloat_IF = JNIEnv.GetMethodID (class_ref, "writeFloat", "(IF)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFloat_IF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeFloatNoTag_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeFloatNoTag' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("writeFloatNoTag", "(F)V", "")]
		public void WriteFloatNoTag (float p0)
		{
			if (id_writeFloatNoTag_F == IntPtr.Zero)
				id_writeFloatNoTag_F = JNIEnv.GetMethodID (class_ref, "writeFloatNoTag", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeFloatNoTag_F, new JValue (p0));
		}

		static IntPtr id_writeInt32_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeInt32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeInt32", "(II)V", "")]
		public void WriteInt32 (int p0, int p1)
		{
			if (id_writeInt32_II == IntPtr.Zero)
				id_writeInt32_II = JNIEnv.GetMethodID (class_ref, "writeInt32", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeInt32_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeInt32NoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeInt32NoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt32NoTag", "(I)V", "")]
		public void WriteInt32NoTag (int p0)
		{
			if (id_writeInt32NoTag_I == IntPtr.Zero)
				id_writeInt32NoTag_I = JNIEnv.GetMethodID (class_ref, "writeInt32NoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeInt32NoTag_I, new JValue (p0));
		}

		static IntPtr id_writeInt64_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeInt64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("writeInt64", "(IJ)V", "")]
		public void WriteInt64 (int p0, long p1)
		{
			if (id_writeInt64_IJ == IntPtr.Zero)
				id_writeInt64_IJ = JNIEnv.GetMethodID (class_ref, "writeInt64", "(IJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeInt64_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeInt64NoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeInt64NoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeInt64NoTag", "(J)V", "")]
		public void WriteInt64NoTag (long p0)
		{
			if (id_writeInt64NoTag_J == IntPtr.Zero)
				id_writeInt64NoTag_J = JNIEnv.GetMethodID (class_ref, "writeInt64NoTag", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeInt64NoTag_J, new JValue (p0));
		}

		static IntPtr id_writeRawByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("writeRawByte", "(B)V", "")]
		public void WriteRawByte (sbyte p0)
		{
			if (id_writeRawByte_B == IntPtr.Zero)
				id_writeRawByte_B = JNIEnv.GetMethodID (class_ref, "writeRawByte", "(B)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawByte_B, new JValue (p0));
		}

		static IntPtr id_writeRawByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeRawByte", "(I)V", "")]
		public void WriteRawByte (int p0)
		{
			if (id_writeRawByte_I == IntPtr.Zero)
				id_writeRawByte_I = JNIEnv.GetMethodID (class_ref, "writeRawByte", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawByte_I, new JValue (p0));
		}

		static IntPtr id_writeRawBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeRawBytes", "([B)V", "")]
		public void WriteRawBytes (byte[] p0)
		{
			if (id_writeRawBytes_arrayB == IntPtr.Zero)
				id_writeRawBytes_arrayB = JNIEnv.GetMethodID (class_ref, "writeRawBytes", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeRawBytes_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeRawBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("writeRawBytes", "([BII)V", "")]
		public void WriteRawBytes (byte[] p0, int p1, int p2)
		{
			if (id_writeRawBytes_arrayBII == IntPtr.Zero)
				id_writeRawBytes_arrayBII = JNIEnv.GetMethodID (class_ref, "writeRawBytes", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeRawBytes_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeRawLittleEndian32_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawLittleEndian32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeRawLittleEndian32", "(I)V", "")]
		public void WriteRawLittleEndian32 (int p0)
		{
			if (id_writeRawLittleEndian32_I == IntPtr.Zero)
				id_writeRawLittleEndian32_I = JNIEnv.GetMethodID (class_ref, "writeRawLittleEndian32", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawLittleEndian32_I, new JValue (p0));
		}

		static IntPtr id_writeRawLittleEndian64_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawLittleEndian64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeRawLittleEndian64", "(J)V", "")]
		public void WriteRawLittleEndian64 (long p0)
		{
			if (id_writeRawLittleEndian64_J == IntPtr.Zero)
				id_writeRawLittleEndian64_J = JNIEnv.GetMethodID (class_ref, "writeRawLittleEndian64", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawLittleEndian64_J, new JValue (p0));
		}

		static IntPtr id_writeRawVarint32_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawVarint32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeRawVarint32", "(I)V", "")]
		public void WriteRawVarint32 (int p0)
		{
			if (id_writeRawVarint32_I == IntPtr.Zero)
				id_writeRawVarint32_I = JNIEnv.GetMethodID (class_ref, "writeRawVarint32", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawVarint32_I, new JValue (p0));
		}

		static IntPtr id_writeRawVarint64_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeRawVarint64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeRawVarint64", "(J)V", "")]
		public void WriteRawVarint64 (long p0)
		{
			if (id_writeRawVarint64_J == IntPtr.Zero)
				id_writeRawVarint64_J = JNIEnv.GetMethodID (class_ref, "writeRawVarint64", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeRawVarint64_J, new JValue (p0));
		}

		static IntPtr id_writeSFixed32_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSFixed32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeSFixed32", "(II)V", "")]
		public void WriteSFixed32 (int p0, int p1)
		{
			if (id_writeSFixed32_II == IntPtr.Zero)
				id_writeSFixed32_II = JNIEnv.GetMethodID (class_ref, "writeSFixed32", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSFixed32_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeSFixed32NoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSFixed32NoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeSFixed32NoTag", "(I)V", "")]
		public void WriteSFixed32NoTag (int p0)
		{
			if (id_writeSFixed32NoTag_I == IntPtr.Zero)
				id_writeSFixed32NoTag_I = JNIEnv.GetMethodID (class_ref, "writeSFixed32NoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSFixed32NoTag_I, new JValue (p0));
		}

		static IntPtr id_writeSFixed64_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSFixed64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("writeSFixed64", "(IJ)V", "")]
		public void WriteSFixed64 (int p0, long p1)
		{
			if (id_writeSFixed64_IJ == IntPtr.Zero)
				id_writeSFixed64_IJ = JNIEnv.GetMethodID (class_ref, "writeSFixed64", "(IJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSFixed64_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeSFixed64NoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSFixed64NoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeSFixed64NoTag", "(J)V", "")]
		public void WriteSFixed64NoTag (long p0)
		{
			if (id_writeSFixed64NoTag_J == IntPtr.Zero)
				id_writeSFixed64NoTag_J = JNIEnv.GetMethodID (class_ref, "writeSFixed64NoTag", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSFixed64NoTag_J, new JValue (p0));
		}

		static IntPtr id_writeSInt32_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSInt32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeSInt32", "(II)V", "")]
		public void WriteSInt32 (int p0, int p1)
		{
			if (id_writeSInt32_II == IntPtr.Zero)
				id_writeSInt32_II = JNIEnv.GetMethodID (class_ref, "writeSInt32", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSInt32_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeSInt32NoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSInt32NoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeSInt32NoTag", "(I)V", "")]
		public void WriteSInt32NoTag (int p0)
		{
			if (id_writeSInt32NoTag_I == IntPtr.Zero)
				id_writeSInt32NoTag_I = JNIEnv.GetMethodID (class_ref, "writeSInt32NoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSInt32NoTag_I, new JValue (p0));
		}

		static IntPtr id_writeSInt64_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSInt64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("writeSInt64", "(IJ)V", "")]
		public void WriteSInt64 (int p0, long p1)
		{
			if (id_writeSInt64_IJ == IntPtr.Zero)
				id_writeSInt64_IJ = JNIEnv.GetMethodID (class_ref, "writeSInt64", "(IJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSInt64_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeSInt64NoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeSInt64NoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeSInt64NoTag", "(J)V", "")]
		public void WriteSInt64NoTag (long p0)
		{
			if (id_writeSInt64NoTag_J == IntPtr.Zero)
				id_writeSInt64NoTag_J = JNIEnv.GetMethodID (class_ref, "writeSInt64NoTag", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeSInt64NoTag_J, new JValue (p0));
		}

		static IntPtr id_writeString_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeString", "(ILjava/lang/String;)V", "")]
		public void WriteString (int p0, string p1)
		{
			if (id_writeString_ILjava_lang_String_ == IntPtr.Zero)
				id_writeString_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeString", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_writeString_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_writeStringNoTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeStringNoTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeStringNoTag", "(Ljava/lang/String;)V", "")]
		public void WriteStringNoTag (string p0)
		{
			if (id_writeStringNoTag_Ljava_lang_String_ == IntPtr.Zero)
				id_writeStringNoTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeStringNoTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeStringNoTag_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_writeTag_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeTag' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeTag", "(II)V", "")]
		public void WriteTag (int p0, int p1)
		{
			if (id_writeTag_II == IntPtr.Zero)
				id_writeTag_II = JNIEnv.GetMethodID (class_ref, "writeTag", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeTag_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeUInt32_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeUInt32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeUInt32", "(II)V", "")]
		public void WriteUInt32 (int p0, int p1)
		{
			if (id_writeUInt32_II == IntPtr.Zero)
				id_writeUInt32_II = JNIEnv.GetMethodID (class_ref, "writeUInt32", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeUInt32_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeUInt32NoTag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeUInt32NoTag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeUInt32NoTag", "(I)V", "")]
		public void WriteUInt32NoTag (int p0)
		{
			if (id_writeUInt32NoTag_I == IntPtr.Zero)
				id_writeUInt32NoTag_I = JNIEnv.GetMethodID (class_ref, "writeUInt32NoTag", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeUInt32NoTag_I, new JValue (p0));
		}

		static IntPtr id_writeUInt64_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeUInt64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("writeUInt64", "(IJ)V", "")]
		public void WriteUInt64 (int p0, long p1)
		{
			if (id_writeUInt64_IJ == IntPtr.Zero)
				id_writeUInt64_IJ = JNIEnv.GetMethodID (class_ref, "writeUInt64", "(IJ)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeUInt64_IJ, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_writeUInt64NoTag_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedOutputStream']/method[@name='writeUInt64NoTag' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeUInt64NoTag", "(J)V", "")]
		public void WriteUInt64NoTag (long p0)
		{
			if (id_writeUInt64NoTag_J == IntPtr.Zero)
				id_writeUInt64NoTag_J = JNIEnv.GetMethodID (class_ref, "writeUInt64NoTag", "(J)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeUInt64NoTag_J, new JValue (p0));
		}

	}
}
