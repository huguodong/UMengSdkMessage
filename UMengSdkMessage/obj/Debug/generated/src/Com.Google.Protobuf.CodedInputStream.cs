using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Protobuf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']"
	[global::Android.Runtime.Register ("com/google/protobuf/CodedInputStream", DoNotGenerateAcw=true)]
	public sealed partial class CodedInputStream : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/protobuf/CodedInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodedInputStream); }
		}

		internal CodedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBytesUntilLimit;
		public int BytesUntilLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='getBytesUntilLimit' and count(parameter)=0]"
			[Register ("getBytesUntilLimit", "()I", "GetGetBytesUntilLimitHandler")]
			get {
				if (id_getBytesUntilLimit == IntPtr.Zero)
					id_getBytesUntilLimit = JNIEnv.GetMethodID (class_ref, "getBytesUntilLimit", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getBytesUntilLimit);
			}
		}

		static IntPtr id_isAtEnd;
		public bool IsAtEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='isAtEnd' and count(parameter)=0]"
			[Register ("isAtEnd", "()Z", "GetIsAtEndHandler")]
			get {
				if (id_isAtEnd == IntPtr.Zero)
					id_isAtEnd = JNIEnv.GetMethodID (class_ref, "isAtEnd", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAtEnd);
			}
		}

		static IntPtr id_getTotalBytesRead;
		public int TotalBytesRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='getTotalBytesRead' and count(parameter)=0]"
			[Register ("getTotalBytesRead", "()I", "GetGetTotalBytesReadHandler")]
			get {
				if (id_getTotalBytesRead == IntPtr.Zero)
					id_getTotalBytesRead = JNIEnv.GetMethodID (class_ref, "getTotalBytesRead", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getTotalBytesRead);
			}
		}

		static IntPtr id_checkLastTagWas_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='checkLastTagWas' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkLastTagWas", "(I)V", "")]
		public void CheckLastTagWas (int p0)
		{
			if (id_checkLastTagWas_I == IntPtr.Zero)
				id_checkLastTagWas_I = JNIEnv.GetMethodID (class_ref, "checkLastTagWas", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_checkLastTagWas_I, new JValue (p0));
		}

		static IntPtr id_decodeZigZag32_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='decodeZigZag32' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decodeZigZag32", "(I)I", "")]
		public static int DecodeZigZag32 (int p0)
		{
			if (id_decodeZigZag32_I == IntPtr.Zero)
				id_decodeZigZag32_I = JNIEnv.GetStaticMethodID (class_ref, "decodeZigZag32", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_decodeZigZag32_I, new JValue (p0));
		}

		static IntPtr id_decodeZigZag64_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='decodeZigZag64' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("decodeZigZag64", "(J)J", "")]
		public static long DecodeZigZag64 (long p0)
		{
			if (id_decodeZigZag64_J == IntPtr.Zero)
				id_decodeZigZag64_J = JNIEnv.GetStaticMethodID (class_ref, "decodeZigZag64", "(J)J");
			return JNIEnv.CallStaticLongMethod  (class_ref, id_decodeZigZag64_J, new JValue (p0));
		}

		static IntPtr id_newInstance_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newInstance", "([B)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (byte[] p0)
		{
			if (id_newInstance_arrayB == IntPtr.Zero)
				id_newInstance_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([B)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='newInstance' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("newInstance", "([BII)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (byte[] p0, int p1, int p2)
		{
			if (id_newInstance_arrayBII == IntPtr.Zero)
				id_newInstance_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "([BII)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newInstance_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("newInstance", "(Ljava/io/InputStream;)Lcom/google/protobuf/CodedInputStream;", "")]
		public static global::Com.Google.Protobuf.CodedInputStream NewInstance (global::System.IO.Stream p0)
		{
			if (id_newInstance_Ljava_io_InputStream_ == IntPtr.Zero)
				id_newInstance_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/io/InputStream;)Lcom/google/protobuf/CodedInputStream;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			global::Com.Google.Protobuf.CodedInputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Protobuf.CodedInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_popLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='popLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("popLimit", "(I)V", "")]
		public void PopLimit (int p0)
		{
			if (id_popLimit_I == IntPtr.Zero)
				id_popLimit_I = JNIEnv.GetMethodID (class_ref, "popLimit", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_popLimit_I, new JValue (p0));
		}

		static IntPtr id_pushLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='pushLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pushLimit", "(I)I", "")]
		public int PushLimit (int p0)
		{
			if (id_pushLimit_I == IntPtr.Zero)
				id_pushLimit_I = JNIEnv.GetMethodID (class_ref, "pushLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_pushLimit_I, new JValue (p0));
		}

		static IntPtr id_readBool;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readBool' and count(parameter)=0]"
		[Register ("readBool", "()Z", "")]
		public bool ReadBool ()
		{
			if (id_readBool == IntPtr.Zero)
				id_readBool = JNIEnv.GetMethodID (class_ref, "readBool", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_readBool);
		}

		static IntPtr id_readDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readDouble' and count(parameter)=0]"
		[Register ("readDouble", "()D", "")]
		public double ReadDouble ()
		{
			if (id_readDouble == IntPtr.Zero)
				id_readDouble = JNIEnv.GetMethodID (class_ref, "readDouble", "()D");
			return JNIEnv.CallDoubleMethod  (Handle, id_readDouble);
		}

		static IntPtr id_readEnum;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readEnum' and count(parameter)=0]"
		[Register ("readEnum", "()I", "")]
		public int ReadEnum ()
		{
			if (id_readEnum == IntPtr.Zero)
				id_readEnum = JNIEnv.GetMethodID (class_ref, "readEnum", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readEnum);
		}

		static IntPtr id_readFixed32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readFixed32' and count(parameter)=0]"
		[Register ("readFixed32", "()I", "")]
		public int ReadFixed32 ()
		{
			if (id_readFixed32 == IntPtr.Zero)
				id_readFixed32 = JNIEnv.GetMethodID (class_ref, "readFixed32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readFixed32);
		}

		static IntPtr id_readFixed64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readFixed64' and count(parameter)=0]"
		[Register ("readFixed64", "()J", "")]
		public long ReadFixed64 ()
		{
			if (id_readFixed64 == IntPtr.Zero)
				id_readFixed64 = JNIEnv.GetMethodID (class_ref, "readFixed64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readFixed64);
		}

		static IntPtr id_readFloat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readFloat' and count(parameter)=0]"
		[Register ("readFloat", "()F", "")]
		public float ReadFloat ()
		{
			if (id_readFloat == IntPtr.Zero)
				id_readFloat = JNIEnv.GetMethodID (class_ref, "readFloat", "()F");
			return JNIEnv.CallFloatMethod  (Handle, id_readFloat);
		}

		static IntPtr id_readInt32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readInt32' and count(parameter)=0]"
		[Register ("readInt32", "()I", "")]
		public int ReadInt32 ()
		{
			if (id_readInt32 == IntPtr.Zero)
				id_readInt32 = JNIEnv.GetMethodID (class_ref, "readInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readInt32);
		}

		static IntPtr id_readInt64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readInt64' and count(parameter)=0]"
		[Register ("readInt64", "()J", "")]
		public long ReadInt64 ()
		{
			if (id_readInt64 == IntPtr.Zero)
				id_readInt64 = JNIEnv.GetMethodID (class_ref, "readInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readInt64);
		}

		static IntPtr id_readRawByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawByte' and count(parameter)=0]"
		[Register ("readRawByte", "()B", "")]
		public sbyte ReadRawByte ()
		{
			if (id_readRawByte == IntPtr.Zero)
				id_readRawByte = JNIEnv.GetMethodID (class_ref, "readRawByte", "()B");
			return JNIEnv.CallByteMethod  (Handle, id_readRawByte);
		}

		static IntPtr id_readRawBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readRawBytes", "(I)[B", "")]
		public byte[] ReadRawBytes (int p0)
		{
			if (id_readRawBytes_I == IntPtr.Zero)
				id_readRawBytes_I = JNIEnv.GetMethodID (class_ref, "readRawBytes", "(I)[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readRawBytes_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_readRawLittleEndian32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawLittleEndian32' and count(parameter)=0]"
		[Register ("readRawLittleEndian32", "()I", "")]
		public int ReadRawLittleEndian32 ()
		{
			if (id_readRawLittleEndian32 == IntPtr.Zero)
				id_readRawLittleEndian32 = JNIEnv.GetMethodID (class_ref, "readRawLittleEndian32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readRawLittleEndian32);
		}

		static IntPtr id_readRawLittleEndian64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawLittleEndian64' and count(parameter)=0]"
		[Register ("readRawLittleEndian64", "()J", "")]
		public long ReadRawLittleEndian64 ()
		{
			if (id_readRawLittleEndian64 == IntPtr.Zero)
				id_readRawLittleEndian64 = JNIEnv.GetMethodID (class_ref, "readRawLittleEndian64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readRawLittleEndian64);
		}

		static IntPtr id_readRawVarint32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawVarint32' and count(parameter)=0]"
		[Register ("readRawVarint32", "()I", "")]
		public int ReadRawVarint32 ()
		{
			if (id_readRawVarint32 == IntPtr.Zero)
				id_readRawVarint32 = JNIEnv.GetMethodID (class_ref, "readRawVarint32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readRawVarint32);
		}

		static IntPtr id_readRawVarint32_ILjava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawVarint32' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("readRawVarint32", "(ILjava/io/InputStream;)I", "")]
		public static int ReadRawVarint32 (int p0, global::System.IO.Stream p1)
		{
			if (id_readRawVarint32_ILjava_io_InputStream_ == IntPtr.Zero)
				id_readRawVarint32_ILjava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readRawVarint32", "(ILjava/io/InputStream;)I");
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readRawVarint32_ILjava_io_InputStream_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_readRawVarint64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readRawVarint64' and count(parameter)=0]"
		[Register ("readRawVarint64", "()J", "")]
		public long ReadRawVarint64 ()
		{
			if (id_readRawVarint64 == IntPtr.Zero)
				id_readRawVarint64 = JNIEnv.GetMethodID (class_ref, "readRawVarint64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readRawVarint64);
		}

		static IntPtr id_readSFixed32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readSFixed32' and count(parameter)=0]"
		[Register ("readSFixed32", "()I", "")]
		public int ReadSFixed32 ()
		{
			if (id_readSFixed32 == IntPtr.Zero)
				id_readSFixed32 = JNIEnv.GetMethodID (class_ref, "readSFixed32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readSFixed32);
		}

		static IntPtr id_readSFixed64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readSFixed64' and count(parameter)=0]"
		[Register ("readSFixed64", "()J", "")]
		public long ReadSFixed64 ()
		{
			if (id_readSFixed64 == IntPtr.Zero)
				id_readSFixed64 = JNIEnv.GetMethodID (class_ref, "readSFixed64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readSFixed64);
		}

		static IntPtr id_readSInt32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readSInt32' and count(parameter)=0]"
		[Register ("readSInt32", "()I", "")]
		public int ReadSInt32 ()
		{
			if (id_readSInt32 == IntPtr.Zero)
				id_readSInt32 = JNIEnv.GetMethodID (class_ref, "readSInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readSInt32);
		}

		static IntPtr id_readSInt64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readSInt64' and count(parameter)=0]"
		[Register ("readSInt64", "()J", "")]
		public long ReadSInt64 ()
		{
			if (id_readSInt64 == IntPtr.Zero)
				id_readSInt64 = JNIEnv.GetMethodID (class_ref, "readSInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readSInt64);
		}

		static IntPtr id_readString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readString' and count(parameter)=0]"
		[Register ("readString", "()Ljava/lang/String;", "")]
		public string ReadString ()
		{
			if (id_readString == IntPtr.Zero)
				id_readString = JNIEnv.GetMethodID (class_ref, "readString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_readTag;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readTag' and count(parameter)=0]"
		[Register ("readTag", "()I", "")]
		public int ReadTag ()
		{
			if (id_readTag == IntPtr.Zero)
				id_readTag = JNIEnv.GetMethodID (class_ref, "readTag", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readTag);
		}

		static IntPtr id_readUInt32;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readUInt32' and count(parameter)=0]"
		[Register ("readUInt32", "()I", "")]
		public int ReadUInt32 ()
		{
			if (id_readUInt32 == IntPtr.Zero)
				id_readUInt32 = JNIEnv.GetMethodID (class_ref, "readUInt32", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_readUInt32);
		}

		static IntPtr id_readUInt64;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='readUInt64' and count(parameter)=0]"
		[Register ("readUInt64", "()J", "")]
		public long ReadUInt64 ()
		{
			if (id_readUInt64 == IntPtr.Zero)
				id_readUInt64 = JNIEnv.GetMethodID (class_ref, "readUInt64", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_readUInt64);
		}

		static IntPtr id_resetSizeCounter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='resetSizeCounter' and count(parameter)=0]"
		[Register ("resetSizeCounter", "()V", "")]
		public void ResetSizeCounter ()
		{
			if (id_resetSizeCounter == IntPtr.Zero)
				id_resetSizeCounter = JNIEnv.GetMethodID (class_ref, "resetSizeCounter", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_resetSizeCounter);
		}

		static IntPtr id_setRecursionLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='setRecursionLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRecursionLimit", "(I)I", "")]
		public int SetRecursionLimit (int p0)
		{
			if (id_setRecursionLimit_I == IntPtr.Zero)
				id_setRecursionLimit_I = JNIEnv.GetMethodID (class_ref, "setRecursionLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setRecursionLimit_I, new JValue (p0));
		}

		static IntPtr id_setSizeLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='setSizeLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSizeLimit", "(I)I", "")]
		public int SetSizeLimit (int p0)
		{
			if (id_setSizeLimit_I == IntPtr.Zero)
				id_setSizeLimit_I = JNIEnv.GetMethodID (class_ref, "setSizeLimit", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setSizeLimit_I, new JValue (p0));
		}

		static IntPtr id_skipField_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='skipField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipField", "(I)Z", "")]
		public bool SkipField (int p0)
		{
			if (id_skipField_I == IntPtr.Zero)
				id_skipField_I = JNIEnv.GetMethodID (class_ref, "skipField", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_skipField_I, new JValue (p0));
		}

		static IntPtr id_skipMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='skipMessage' and count(parameter)=0]"
		[Register ("skipMessage", "()V", "")]
		public void SkipMessage ()
		{
			if (id_skipMessage == IntPtr.Zero)
				id_skipMessage = JNIEnv.GetMethodID (class_ref, "skipMessage", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_skipMessage);
		}

		static IntPtr id_skipRawBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.protobuf']/class[@name='CodedInputStream']/method[@name='skipRawBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipRawBytes", "(I)V", "")]
		public void SkipRawBytes (int p0)
		{
			if (id_skipRawBytes_I == IntPtr.Zero)
				id_skipRawBytes_I = JNIEnv.GetMethodID (class_ref, "skipRawBytes", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_skipRawBytes_I, new JValue (p0));
		}

	}
}
