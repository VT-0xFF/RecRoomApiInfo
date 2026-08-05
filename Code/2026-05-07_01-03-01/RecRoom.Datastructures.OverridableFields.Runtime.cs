using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.OverridableFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface ZBOKGQTTOHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface MOAWZHHDPZR<a> : ZBOKGQTTOHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface TXYVLGAELIX<a> : MOAWZHHDPZR<a>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		new bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		new a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OGDOLKSCYEI<a> : TXYVLGAELIX<a>, MOAWZHHDPZR<a>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KWSDZRTZRSW
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97EBA10", Offset = "0x97EA410", VA = "0x1897EBA10")]
		public static float? YIVRKFJDWCQ(this OverridableFloat a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : MOAWZHHDPZR<int>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x10A8E10", Offset = "0x10A7810", VA = "0x1810A8E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97ED1F0", Offset = "0x97EBBF0", VA = "0x1897ED1F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x30B9B60", Offset = "0x30B8560", VA = "0x1830B9B60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x97ED170", Offset = "0x97EBB70", VA = "0x1897ED170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableFloat : MOAWZHHDPZR<float>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x10A8E10", Offset = "0x10A7810", VA = "0x1810A8E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x97ED140", Offset = "0x97EBB40", VA = "0x1897ED140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2E2CFD0", Offset = "0x2E2B9D0", VA = "0x182E2CFD0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x97ED0C0", Offset = "0x97EBAC0", VA = "0x1897ED0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OverridableString : MOAWZHHDPZR<string>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10A8E10", Offset = "0x10A7810", VA = "0x1810A8E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF22E20", Offset = "0xF21820", VA = "0x180F22E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x97ED220", Offset = "0x97EBC20", VA = "0x1897ED220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class WWEJNYDEDLJ<a, b, c> : TXYVLGAELIX<b>, MOAWZHHDPZR<b>, ZBOKGQTTOHG where a : WWEJNYDEDLJ<a, b, c> where c : IMessage<c>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract b Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1710", Offset = "0x2DB0110", VA = "0x182DB1710", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85AC110", Offset = "0x85AAB10", VA = "0x1885AC110")]
		public WWEJNYDEDLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85AC0B0", Offset = "0x85AAAB0", VA = "0x1885AC0B0")]
		public WWEJNYDEDLJ(bool a, [NotNull] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85AB3D0", Offset = "0x85A9DD0", VA = "0x1885AB3D0", Slot = "15")]
		public void ASEEJXJLRJD(MOAWZHHDPZR<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85AB820", Offset = "0x85AA220", VA = "0x1885AB820", Slot = "16")]
		public void Copy(MOAWZHHDPZR<b> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85ABDD0", Offset = "0x85AA7D0", VA = "0x1885ABDD0", Slot = "17")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract c ECEZEAWUTPS();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void YDFQLXWLYVC(c a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void TWUDVWCNGYP(byte[] a);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : WWEJNYDEDLJ<T, InnerType, ProtobufType> where T : WWEJNYDEDLJ<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD28710", Offset = "0xD27110", VA = "0x180D28710", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xDDC880", Offset = "0xDDB280", VA = "0x180DDC880", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF6ABC0", Offset = "0xF695C0", VA = "0x180F6ABC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79A6030", Offset = "0x79A4A30", VA = "0x1879A6030")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x79A61B0", Offset = "0x79A4BB0", VA = "0x1879A61B0")]
		public SerializedMutableOverridableBase(bool overrides, InnerType value)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PNPPUWXYBCK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97ECFF0", Offset = "0x97EB9F0", VA = "0x1897ECFF0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97ED050", Offset = "0x97EBA50", VA = "0x1897ED050")]
		public MutableOverridableObscuredInt(bool overrides, ObscuredInt value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x97ECE80", Offset = "0x97EB880", VA = "0x1897ECE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x97ECDA0", Offset = "0x97EB7A0", VA = "0x1897ECDA0", Slot = "20")]
		public override void TWUDVWCNGYP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97ECF40", Offset = "0x97EB940", VA = "0x1897ECF40", Slot = "19")]
		public override void YDFQLXWLYVC(PNPPUWXYBCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97ECCC0", Offset = "0x97EB6C0", VA = "0x1897ECCC0", Slot = "18")]
		public override PNPPUWXYBCK ECEZEAWUTPS()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, AXLESOGWXPX>
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x97ECBF0", Offset = "0x97EB5F0", VA = "0x1897ECBF0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97ECC50", Offset = "0x97EB650", VA = "0x1897ECC50")]
		public MutableOverridableObscuredFloat(bool overrides, ObscuredFloat value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97ECA60", Offset = "0x97EB460", VA = "0x1897ECA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97EC980", Offset = "0x97EB380", VA = "0x1897EC980", Slot = "20")]
		public override void TWUDVWCNGYP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x97ECB30", Offset = "0x97EB530", VA = "0x1897ECB30", Slot = "19")]
		public override void YDFQLXWLYVC(AXLESOGWXPX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97EC890", Offset = "0x97EB290", VA = "0x1897EC890", Slot = "18")]
		public override AXLESOGWXPX ECEZEAWUTPS()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, BHUMYXXICVX>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97EBAF0", Offset = "0x97EA4F0", VA = "0x1897EBAF0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97EC820", Offset = "0x97EB220", VA = "0x1897EC820")]
		public MutableOverridableObscuredBool(bool overrides, ObscuredBool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97EC690", Offset = "0x97EB090", VA = "0x1897EC690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x97EC5B0", Offset = "0x97EAFB0", VA = "0x1897EC5B0", Slot = "20")]
		public override void TWUDVWCNGYP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x97EC760", Offset = "0x97EB160", VA = "0x1897EC760", Slot = "19")]
		public override void YDFQLXWLYVC(BHUMYXXICVX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x97EC440", Offset = "0x97EAE40", VA = "0x1897EC440", Slot = "18")]
		public override BHUMYXXICVX ECEZEAWUTPS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97EC520", Offset = "0x97EAF20", VA = "0x1897EC520", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, OGDOLKSCYEI<ObscuredBool>, TXYVLGAELIX<ObscuredBool>, MOAWZHHDPZR<ObscuredBool>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x97EBAF0", Offset = "0x97EA4F0", VA = "0x1897EBAF0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97EBA70", Offset = "0x97EA470", VA = "0x1897EBA70")]
		public void ASEEJXJLRJD(MutableOverridableDefaultableObscuredBool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PNPPUWXYBCK> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x79A6BF0", Offset = "0x79A55F0", VA = "0x1879A6BF0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x79A6E60", Offset = "0x79A5860", VA = "0x1879A6E60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79A6B50", Offset = "0x79A5550", VA = "0x1879A6B50")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79A6BD0", Offset = "0x79A55D0", VA = "0x1879A6BD0")]
		public SerializedMutableOverridableObscuredEnum(bool overrides, TObsEnum value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79A64B0", Offset = "0x79A4EB0", VA = "0x1879A64B0", Slot = "18")]
		public sealed override PNPPUWXYBCK ECEZEAWUTPS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x79A6940", Offset = "0x79A5340", VA = "0x1879A6940", Slot = "19")]
		public sealed override void YDFQLXWLYVC(PNPPUWXYBCK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x79A6860", Offset = "0x79A5260", VA = "0x1879A6860", Slot = "20")]
		public sealed override void TWUDVWCNGYP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x79A6710", Offset = "0x79A5110", VA = "0x1879A6710", Slot = "17")]
		public sealed override void Reset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, KFAPMPWZOQI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x97EC370", Offset = "0x97EAD70", VA = "0x1897EC370", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x97EC3B0", Offset = "0x97EADB0", VA = "0x1897EC3B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x97EC2E0", Offset = "0x97EACE0", VA = "0x1897EC2E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97EC280", Offset = "0x97EAC80", VA = "0x1897EC280")]
		public MutableOverridableListObscuredString(bool overrides, List<ObscuredString> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97EBEB0", Offset = "0x97EA8B0", VA = "0x1897EBEB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97EBD40", Offset = "0x97EA740", VA = "0x1897EBD40", Slot = "17")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97EBDD0", Offset = "0x97EA7D0", VA = "0x1897EBDD0", Slot = "20")]
		public override void TWUDVWCNGYP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x97EBF40", Offset = "0x97EA940", VA = "0x1897EBF40", Slot = "19")]
		public override void YDFQLXWLYVC(KFAPMPWZOQI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97EBB60", Offset = "0x97EA560", VA = "0x1897EBB60", Slot = "18")]
		public override KFAPMPWZOQI ECEZEAWUTPS()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OverridableVector3 : MOAWZHHDPZR<Vector3>, ZBOKGQTTOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10A8E10", Offset = "0x10A7810", VA = "0x1810A8E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x97ED320", Offset = "0x97EBD20", VA = "0x1897ED320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD31E30", Offset = "0xD30830", VA = "0x180D31E30", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x72D0840", Offset = "0x72CF240", VA = "0x1872D0840")]
		public OverridableVector3(Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8083360", Offset = "0x8081D60", VA = "0x188083360")]
		public OverridableVector3(bool overrides, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97ED280", Offset = "0x97EBC80", VA = "0x1897ED280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97ED370", Offset = "0x97EBD70", VA = "0x1897ED370")]
		public static implicit operator OverridableVector3(Vector3 val)
		{
			return default(OverridableVector3);
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
