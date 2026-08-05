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
public interface MHNCCLDEMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GEFNKCGCMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JGHBFIMCGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FLJDPEGBJJE<T> : MHNCCLDEMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIADJBIIFDJ<T> : FLJDPEGBJJE<T>, MHNCCLDEMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool GEFNKCGCMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T KHLHBLNGCMJ
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
public interface COMMLBMBBMF<T> : KIADJBIIFDJ<T>, FLJDPEGBJJE<T>, MHNCCLDEMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BMEAPJNOGNI
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
	public struct OverridableInt : FLJDPEGBJJE<int>, MHNCCLDEMAJ
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
			[Cpp2IlInjected.Address(RVA = "0x1E5D110", Offset = "0x1E5C510", VA = "0x181E5D110", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x68C6E40", Offset = "0x68C6240", VA = "0x1868C6E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x258C120", Offset = "0x258B520", VA = "0x18258C120", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68C6DA0", Offset = "0x68C61A0", VA = "0x1868C6DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : FLJDPEGBJJE<string>, MHNCCLDEMAJ
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
			[Cpp2IlInjected.Address(RVA = "0x1E5D110", Offset = "0x1E5C510", VA = "0x181E5D110", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x99D390", Offset = "0x99C790", VA = "0x18099D390", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x99D390", Offset = "0x99C790", VA = "0x18099D390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68C6E90", Offset = "0x68C6290", VA = "0x1868C6E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KIADJBIIFDJ<InnerType>, FLJDPEGBJJE<InnerType>, MHNCCLDEMAJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool GEFNKCGCMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JGHBFIMCGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2198F10", Offset = "0x2198310", VA = "0x182198F10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44D5310", Offset = "0x44D4710", VA = "0x1844D5310")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x44D5340", Offset = "0x44D4740", VA = "0x1844D5340")]
		public MutableOverridableBase(bool ELEDDNIPAHK, [NotNull] InnerType OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x44D4B20", Offset = "0x44D3F20", VA = "0x1844D4B20", Slot = "15")]
		public void DHOHFKNKDBC(FLJDPEGBJJE<InnerType> CHCMOMPHENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x44D4EF0", Offset = "0x44D42F0", VA = "0x1844D4EF0", Slot = "16")]
		public void MFEBHLHMDPE(FLJDPEGBJJE<InnerType> IEDCHGMDIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44D4E50", Offset = "0x44D4250", VA = "0x1844D4E50", Slot = "17")]
		public virtual void FCLPPFCBMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType JJKAJKCNKEC();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JLDMGADJLBF(ProtobufType ILGBPHKLPNN);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OBNFLCKFIKB(byte[] DMOBAPMNDDE);
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
			[Cpp2IlInjected.Address(RVA = "0x89D6E0", Offset = "0x89CAE0", VA = "0x18089D6E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA9F640", Offset = "0xA9EA40", VA = "0x180A9F640", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1D4F720", Offset = "0x1D4EB20", VA = "0x181D4F720", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49D8F10", Offset = "0x49D8310", VA = "0x1849D8F10")]
		public SerializedMutableOverridableBase(bool ELEDDNIPAHK, InnerType OBEEJPGJPFD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, MFPODMFGNAA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68C6CD0", Offset = "0x68C60D0", VA = "0x1868C6CD0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68C6D30", Offset = "0x68C6130", VA = "0x1868C6D30")]
		public MutableOverridableObscuredInt(bool ELEDDNIPAHK, ObscuredInt OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68C6C00", Offset = "0x68C6000", VA = "0x1868C6C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68C6B20", Offset = "0x68C5F20", VA = "0x1868C6B20", Slot = "20")]
		public override void OBNFLCKFIKB(byte[] DMOBAPMNDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68C6A70", Offset = "0x68C5E70", VA = "0x1868C6A70", Slot = "19")]
		public override void JLDMGADJLBF(MFPODMFGNAA ILGBPHKLPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68C6990", Offset = "0x68C5D90", VA = "0x1868C6990", Slot = "18")]
		public override MFPODMFGNAA JJKAJKCNKEC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, FKOAIGDFHMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68C68C0", Offset = "0x68C5CC0", VA = "0x1868C68C0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68C6920", Offset = "0x68C5D20", VA = "0x1868C6920")]
		public MutableOverridableObscuredFloat(bool ELEDDNIPAHK, ObscuredFloat OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68C67F0", Offset = "0x68C5BF0", VA = "0x1868C67F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68C6710", Offset = "0x68C5B10", VA = "0x1868C6710", Slot = "20")]
		public override void OBNFLCKFIKB(byte[] DMOBAPMNDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68C6650", Offset = "0x68C5A50", VA = "0x1868C6650", Slot = "19")]
		public override void JLDMGADJLBF(FKOAIGDFHMJ ILGBPHKLPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68C6560", Offset = "0x68C5960", VA = "0x1868C6560", Slot = "18")]
		public override FKOAIGDFHMJ JJKAJKCNKEC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, IFNBFOHHCOL>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68C5760", Offset = "0x68C4B60", VA = "0x1868C5760")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68C64F0", Offset = "0x68C58F0", VA = "0x1868C64F0")]
		public MutableOverridableObscuredBool(bool ELEDDNIPAHK, ObscuredBool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68C6420", Offset = "0x68C5820", VA = "0x1868C6420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68C62B0", Offset = "0x68C56B0", VA = "0x1868C62B0", Slot = "20")]
		public override void OBNFLCKFIKB(byte[] DMOBAPMNDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68C61F0", Offset = "0x68C55F0", VA = "0x1868C61F0", Slot = "19")]
		public override void JLDMGADJLBF(IFNBFOHHCOL ILGBPHKLPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68C6100", Offset = "0x68C5500", VA = "0x1868C6100", Slot = "18")]
		public override IFNBFOHHCOL JJKAJKCNKEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68C6390", Offset = "0x68C5790", VA = "0x1868C6390", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, COMMLBMBBMF<ObscuredBool>, KIADJBIIFDJ<ObscuredBool>, FLJDPEGBJJE<ObscuredBool>, MHNCCLDEMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x854200", Offset = "0x853600", VA = "0x180854200", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x853FA0", Offset = "0x8533A0", VA = "0x180853FA0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68C5760", Offset = "0x68C4B60", VA = "0x1868C5760")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68C56E0", Offset = "0x68C4AE0", VA = "0x1868C56E0")]
		public void DHOHFKNKDBC(MutableOverridableDefaultableObscuredBool IEDCHGMDIML)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, MFPODMFGNAA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x49D93A0", Offset = "0x49D87A0", VA = "0x1849D93A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x49D9520", Offset = "0x49D8920", VA = "0x1849D9520", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DFE0", Offset = "0x3E4D3E0", VA = "0x183E4DFE0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49D9360", Offset = "0x49D8760", VA = "0x1849D9360")]
		public SerializedMutableOverridableObscuredEnum(bool ELEDDNIPAHK, TObsEnum OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49D9090", Offset = "0x49D8490", VA = "0x1849D9090", Slot = "18")]
		public sealed override MFPODMFGNAA JJKAJKCNKEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49D9180", Offset = "0x49D8580", VA = "0x1849D9180", Slot = "19")]
		public sealed override void JLDMGADJLBF(MFPODMFGNAA ILGBPHKLPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x49D9280", Offset = "0x49D8680", VA = "0x1849D9280", Slot = "20")]
		public sealed override void OBNFLCKFIKB(byte[] DMOBAPMNDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49D9010", Offset = "0x49D8410", VA = "0x1849D9010", Slot = "17")]
		public sealed override void FCLPPFCBMBC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EGHAHDBGOPB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x68C6030", Offset = "0x68C5430", VA = "0x1868C6030", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68C6070", Offset = "0x68C5470", VA = "0x1868C6070", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68C5F90", Offset = "0x68C5390", VA = "0x1868C5F90")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68C5F30", Offset = "0x68C5330", VA = "0x1868C5F30")]
		public MutableOverridableListObscuredString(bool ELEDDNIPAHK, List<ObscuredString> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68C5E90", Offset = "0x68C5290", VA = "0x1868C5E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68C57D0", Offset = "0x68C4BD0", VA = "0x1868C57D0", Slot = "17")]
		public override void FCLPPFCBMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x68C5DB0", Offset = "0x68C51B0", VA = "0x1868C5DB0", Slot = "20")]
		public override void OBNFLCKFIKB(byte[] DMOBAPMNDDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68C5A40", Offset = "0x68C4E40", VA = "0x1868C5A40", Slot = "19")]
		public override void JLDMGADJLBF(EGHAHDBGOPB ILGBPHKLPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68C5860", Offset = "0x68C4C60", VA = "0x1868C5860", Slot = "18")]
		public override EGHAHDBGOPB JJKAJKCNKEC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : FLJDPEGBJJE<Vector3>, MHNCCLDEMAJ
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
			[Cpp2IlInjected.Address(RVA = "0x1E5D110", Offset = "0x1E5C510", VA = "0x181E5D110", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x68C6FC0", Offset = "0x68C63C0", VA = "0x1868C6FC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x420E0D0", Offset = "0x420D4D0", VA = "0x18420E0D0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4649F60", Offset = "0x4649360", VA = "0x184649F60")]
		public OverridableVector3(Vector3 OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C6B730", Offset = "0x4C6AB30", VA = "0x184C6B730")]
		public OverridableVector3(bool ELEDDNIPAHK, Vector3 OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68C6F20", Offset = "0x68C6320", VA = "0x1868C6F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68C6F00", Offset = "0x68C6300", VA = "0x1868C6F00")]
		public static OverridableVector3 JHFAHDJBNPM(Vector3 ELOBPEFBAOG)
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
