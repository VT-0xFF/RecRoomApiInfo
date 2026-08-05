using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AKEJPBAGMOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IHCIBJMJAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object HDLEDLJJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OBCJCCJCIBL<T> : AKEJPBAGMOD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BCGINCMENAO<T> : OBCJCCJCIBL<T>, AKEJPBAGMOD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IHCIBJMJAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DHGNDNJJJIH
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
public interface GMPEAPECCKJ<T> : BCGINCMENAO<T>, OBCJCCJCIBL<T>, AKEJPBAGMOD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HBHBDDFMFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableInt : OBCJCCJCIBL<int>, AKEJPBAGMOD
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x19AB520", Offset = "0x19AA320", VA = "0x1819AB520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5DBBCC0", Offset = "0x5DBAAC0", VA = "0x185DBBCC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x208FBA0", Offset = "0x208E9A0", VA = "0x18208FBA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBC20", Offset = "0x5DBAA20", VA = "0x185DBBC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : OBCJCCJCIBL<string>, AKEJPBAGMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x19AB520", Offset = "0x19AA320", VA = "0x1819AB520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7FF8E0", Offset = "0x7FE6E0", VA = "0x1807FF8E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7FF8E0", Offset = "0x7FE6E0", VA = "0x1807FF8E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBD10", Offset = "0x5DBAB10", VA = "0x185DBBD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : BCGINCMENAO<InnerType>, OBCJCCJCIBL<InnerType>, AKEJPBAGMOD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IHCIBJMJAPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType DHGNDNJJJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object HDLEDLJJFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3CFDEA0", Offset = "0x3CFCCA0", VA = "0x183CFDEA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDB60", Offset = "0x3CFC960", VA = "0x183CFDB60")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDB90", Offset = "0x3CFC990", VA = "0x183CFDB90")]
		public MutableOverridableBase(bool HBDENKEPEDJ, [NotNull] InnerType PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CFD290", Offset = "0x3CFC090", VA = "0x183CFD290", Slot = "15")]
		public void BDEHPLCAHMJ(OBCJCCJCIBL<InnerType> BFNCLPMIKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3CFD960", Offset = "0x3CFC760", VA = "0x183CFD960", Slot = "16")]
		public void KLIGLKFNLOP(OBCJCCJCIBL<InnerType> LCIDHBCOPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CFD6B0", Offset = "0x3CFC4B0", VA = "0x183CFD6B0", Slot = "17")]
		public virtual void KICOEKABIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType EBAIMCJLMCI();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GBHLCIGOFMF(ProtobufType JKAIPDAIMND);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void IFEKFJPBEKO(byte[] ELDMFFFFCPO);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7C3260", Offset = "0x7C2060", VA = "0x1807C3260", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8F3300", Offset = "0x8F2100", VA = "0x1808F3300", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x18D1170", Offset = "0x18CFF70", VA = "0x1818D1170", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35DDEA0", Offset = "0x35DCCA0", VA = "0x1835DDEA0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0F40", Offset = "0x3A9FD40", VA = "0x183AA0F40")]
		public SerializedMutableOverridableBase(bool HBDENKEPEDJ, InnerType PHPDIJICBJO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, JBEELHJBCOG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBB50", Offset = "0x5DBA950", VA = "0x185DBBB50")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBBB0", Offset = "0x5DBA9B0", VA = "0x185DBBBB0")]
		public MutableOverridableObscuredInt(bool HBDENKEPEDJ, ObscuredInt PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBA80", Offset = "0x5DBA880", VA = "0x185DBBA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB9A0", Offset = "0x5DBA7A0", VA = "0x185DBB9A0", Slot = "20")]
		public override void IFEKFJPBEKO(byte[] ELDMFFFFCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB8F0", Offset = "0x5DBA6F0", VA = "0x185DBB8F0", Slot = "19")]
		public override void GBHLCIGOFMF(JBEELHJBCOG JKAIPDAIMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB810", Offset = "0x5DBA610", VA = "0x185DBB810", Slot = "18")]
		public override JBEELHJBCOG EBAIMCJLMCI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LABEELLGOOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB740", Offset = "0x5DBA540", VA = "0x185DBB740")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB7A0", Offset = "0x5DBA5A0", VA = "0x185DBB7A0")]
		public MutableOverridableObscuredFloat(bool HBDENKEPEDJ, ObscuredFloat PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB670", Offset = "0x5DBA470", VA = "0x185DBB670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB590", Offset = "0x5DBA390", VA = "0x185DBB590", Slot = "20")]
		public override void IFEKFJPBEKO(byte[] ELDMFFFFCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB4D0", Offset = "0x5DBA2D0", VA = "0x185DBB4D0", Slot = "19")]
		public override void GBHLCIGOFMF(LABEELLGOOJ JKAIPDAIMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB3E0", Offset = "0x5DBA1E0", VA = "0x185DBB3E0", Slot = "18")]
		public override LABEELLGOOJ EBAIMCJLMCI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PGALHFJAONP>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA5F0", Offset = "0x5DB93F0", VA = "0x185DBA5F0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB370", Offset = "0x5DBA170", VA = "0x185DBB370")]
		public MutableOverridableObscuredBool(bool HBDENKEPEDJ, ObscuredBool PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB2A0", Offset = "0x5DBA0A0", VA = "0x185DBB2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB130", Offset = "0x5DB9F30", VA = "0x185DBB130", Slot = "20")]
		public override void IFEKFJPBEKO(byte[] ELDMFFFFCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB070", Offset = "0x5DB9E70", VA = "0x185DBB070", Slot = "19")]
		public override void GBHLCIGOFMF(PGALHFJAONP JKAIPDAIMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAF80", Offset = "0x5DB9D80", VA = "0x185DBAF80", Slot = "18")]
		public override PGALHFJAONP EBAIMCJLMCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB210", Offset = "0x5DBA010", VA = "0x185DBB210", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, GMPEAPECCKJ<ObscuredBool>, BCGINCMENAO<ObscuredBool>, OBCJCCJCIBL<ObscuredBool>, AKEJPBAGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7729A0", Offset = "0x7717A0", VA = "0x1807729A0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7729B0", Offset = "0x7717B0", VA = "0x1807729B0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA5F0", Offset = "0x5DB93F0", VA = "0x185DBA5F0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA570", Offset = "0x5DB9370", VA = "0x185DBA570")]
		public void BDEHPLCAHMJ(MutableOverridableDefaultableObscuredBool LCIDHBCOPEO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, JBEELHJBCOG> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x40EA180", Offset = "0x40E8F80", VA = "0x1840EA180", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x40EA2B0", Offset = "0x40E90B0", VA = "0x1840EA2B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x30FAEF0", Offset = "0x30F9CF0", VA = "0x1830FAEF0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x40EA160", Offset = "0x40E8F60", VA = "0x1840EA160")]
		public SerializedMutableOverridableObscuredEnum(bool HBDENKEPEDJ, TObsEnum PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40E9E20", Offset = "0x40E8C20", VA = "0x1840E9E20", Slot = "18")]
		public sealed override JBEELHJBCOG EBAIMCJLMCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x40E9F10", Offset = "0x40E8D10", VA = "0x1840E9F10", Slot = "19")]
		public sealed override void GBHLCIGOFMF(JBEELHJBCOG JKAIPDAIMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40EA010", Offset = "0x40E8E10", VA = "0x1840EA010", Slot = "20")]
		public sealed override void IFEKFJPBEKO(byte[] ELDMFFFFCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40EA0F0", Offset = "0x40E8EF0", VA = "0x1840EA0F0", Slot = "17")]
		public sealed override void KICOEKABIEM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BIHEFNIGHAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAEB0", Offset = "0x5DB9CB0", VA = "0x185DBAEB0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAEF0", Offset = "0x5DB9CF0", VA = "0x185DBAEF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAE10", Offset = "0x5DB9C10", VA = "0x185DBAE10")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DBADB0", Offset = "0x5DB9BB0", VA = "0x185DBADB0")]
		public MutableOverridableListObscuredString(bool HBDENKEPEDJ, List<ObscuredString> PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAD10", Offset = "0x5DB9B10", VA = "0x185DBAD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DBAC80", Offset = "0x5DB9A80", VA = "0x185DBAC80", Slot = "17")]
		public override void KICOEKABIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBABA0", Offset = "0x5DB99A0", VA = "0x185DBABA0", Slot = "20")]
		public override void IFEKFJPBEKO(byte[] ELDMFFFFCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA840", Offset = "0x5DB9640", VA = "0x185DBA840", Slot = "19")]
		public override void GBHLCIGOFMF(BIHEFNIGHAF JKAIPDAIMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA660", Offset = "0x5DB9460", VA = "0x185DBA660", Slot = "18")]
		public override BIHEFNIGHAF EBAIMCJLMCI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : OBCJCCJCIBL<Vector3>, AKEJPBAGMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x19AB520", Offset = "0x19AA320", VA = "0x1819AB520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5DBBE40", Offset = "0x5DBAC40", VA = "0x185DBBE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E9C0", Offset = "0x3A9D7C0", VA = "0x183A9E9C0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5600", Offset = "0x3DC4400", VA = "0x183DC5600")]
		public OverridableVector3(Vector3 PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBDA0", Offset = "0x5DBABA0", VA = "0x185DBBDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBD80", Offset = "0x5DBAB80", VA = "0x185DBBD80")]
		public static OverridableVector3 DNODACOFDOB(Vector3 DEEINHGIBAA)
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
