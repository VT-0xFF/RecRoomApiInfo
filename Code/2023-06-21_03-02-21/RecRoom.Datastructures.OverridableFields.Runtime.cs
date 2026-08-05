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
public interface COKFABPDKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OFKABJENLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AADCJFEFMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PAKNFJLOGFM<T> : COKFABPDKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JLIOKDOEJNK<T> : PAKNFJLOGFM<T>, COKFABPDKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OFKABJENLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T IHPKAGOHFMA
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
public interface DDMNPNMIFAA<T> : JLIOKDOEJNK<T>, PAKNFJLOGFM<T>, COKFABPDKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BNJEEENPLOL
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
	public struct OverridableVector3 : PAKNFJLOGFM<Vector3>, COKFABPDKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1584AB0", Offset = "0x1583CB0", VA = "0x181584AB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1584C20", Offset = "0x1583E20", VA = "0x181584C20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1584C70", Offset = "0x1583E70", VA = "0x181584C70", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1584C00", Offset = "0x1583E00", VA = "0x181584C00")]
		public OverridableVector3(Vector3 ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1584B60", Offset = "0x1583D60", VA = "0x181584B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1584B30", Offset = "0x1583D30", VA = "0x181584B30")]
		public static OverridableVector3 MDCOPBLGMCP(Vector3 HKPIHPOEJGA)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : PAKNFJLOGFM<int>, COKFABPDKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1584AB0", Offset = "0x1583CB0", VA = "0x181584AB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1584A60", Offset = "0x1583C60", VA = "0x181584A60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD47520", Offset = "0xD46720", VA = "0x180D47520", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15849C0", Offset = "0x1583BC0", VA = "0x1815849C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : PAKNFJLOGFM<string>, COKFABPDKGA
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
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1584AB0", Offset = "0x1583CB0", VA = "0x181584AB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xECA1F0", Offset = "0xEC93F0", VA = "0x180ECA1F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xECA1F0", Offset = "0xEC93F0", VA = "0x180ECA1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1584AC0", Offset = "0x1583CC0", VA = "0x181584AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : JLIOKDOEJNK<InnerType>, PAKNFJLOGFM<InnerType>, COKFABPDKGA where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool OFKABJENLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType IHPKAGOHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object AADCJFEFMII
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2D4DE30", Offset = "0x2D4D030", VA = "0x182D4DE30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3919A30", Offset = "0x3918C30", VA = "0x183919A30")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3919AF0", Offset = "0x3918CF0", VA = "0x183919AF0")]
		public MutableOverridableBase(bool ILCKLMFHNBD, [NotNull] InnerType ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39195A0", Offset = "0x39187A0", VA = "0x1839195A0", Slot = "15")]
		public void OPKPIGLBFOI(PAKNFJLOGFM<InnerType> LJBPMOBENJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39194D0", Offset = "0x39186D0", VA = "0x1839194D0", Slot = "16")]
		public void DJIGAFGLBEH(PAKNFJLOGFM<InnerType> HPOECFLNEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3919000", Offset = "0x3918200", VA = "0x183919000", Slot = "17")]
		public virtual void BLKLFBLJHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType ANAJLIEIKDG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void ICMKANAEANP(ProtobufType LGJPMIDIPNK);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EOMGBDBAHDG(byte[] ONGOKCMMCIN);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
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
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA25640", Offset = "0xA24840", VA = "0x180A25640", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8DC340", Offset = "0x8DB540", VA = "0x1808DC340", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x96EA60", Offset = "0x96DC60", VA = "0x18096EA60", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2844D00", Offset = "0x2843F00", VA = "0x182844D00", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19D5A50", Offset = "0x19D4C50", VA = "0x1819D5A50")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDF70", Offset = "0x1CBD170", VA = "0x181CBDF70")]
		public SerializedMutableOverridableBase(bool ILCKLMFHNBD, InnerType ACKOJNNBEBO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HHENNJECBLH>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1584960", Offset = "0x1583B60", VA = "0x181584960")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x15848F0", Offset = "0x1583AF0", VA = "0x1815848F0")]
		public MutableOverridableObscuredInt(bool ILCKLMFHNBD, ObscuredInt ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1584820", Offset = "0x1583A20", VA = "0x181584820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x15846A0", Offset = "0x15838A0", VA = "0x1815846A0", Slot = "20")]
		public override void EOMGBDBAHDG(byte[] ONGOKCMMCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1584750", Offset = "0x1583950", VA = "0x181584750", Slot = "19")]
		public override void ICMKANAEANP(HHENNJECBLH LGJPMIDIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x15845A0", Offset = "0x15837A0", VA = "0x1815845A0", Slot = "18")]
		public override HHENNJECBLH ANAJLIEIKDG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LNJGPKKLJHM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x15844D0", Offset = "0x15836D0", VA = "0x1815844D0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1584530", Offset = "0x1583730", VA = "0x181584530")]
		public MutableOverridableObscuredFloat(bool ILCKLMFHNBD, ObscuredFloat ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1584400", Offset = "0x1583600", VA = "0x181584400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1584270", Offset = "0x1583470", VA = "0x181584270", Slot = "20")]
		public override void EOMGBDBAHDG(byte[] ONGOKCMMCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1584320", Offset = "0x1583520", VA = "0x181584320", Slot = "19")]
		public override void ICMKANAEANP(LNJGPKKLJHM LGJPMIDIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1584160", Offset = "0x1583360", VA = "0x181584160", Slot = "18")]
		public override LNJGPKKLJHM ANAJLIEIKDG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EIHMNMLEOCI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1583450", Offset = "0x1582650", VA = "0x181583450")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x15840F0", Offset = "0x15832F0", VA = "0x1815840F0")]
		public MutableOverridableObscuredBool(bool ILCKLMFHNBD, ObscuredBool ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1584020", Offset = "0x1583220", VA = "0x181584020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1583E40", Offset = "0x1583040", VA = "0x181583E40", Slot = "20")]
		public override void EOMGBDBAHDG(byte[] ONGOKCMMCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1583EF0", Offset = "0x15830F0", VA = "0x181583EF0", Slot = "19")]
		public override void ICMKANAEANP(EIHMNMLEOCI LGJPMIDIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1583D40", Offset = "0x1582F40", VA = "0x181583D40", Slot = "18")]
		public override EIHMNMLEOCI ANAJLIEIKDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1583FD0", Offset = "0x15831D0", VA = "0x181583FD0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, DDMNPNMIFAA<ObscuredBool>, JLIOKDOEJNK<ObscuredBool>, PAKNFJLOGFM<ObscuredBool>, COKFABPDKGA
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8F3030", Offset = "0x8F2230", VA = "0x1808F3030", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x971F20", Offset = "0x971120", VA = "0x180971F20", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1583450", Offset = "0x1582650", VA = "0x181583450")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x15833D0", Offset = "0x15825D0", VA = "0x1815833D0")]
		public void OPKPIGLBFOI(MutableOverridableDefaultableObscuredBool HPOECFLNEOJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HHENNJECBLH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3CB8340", Offset = "0x3CB7540", VA = "0x183CB8340", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3CB8420", Offset = "0x3CB7620", VA = "0x183CB8420", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x275E9C0", Offset = "0x275DBC0", VA = "0x18275E9C0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8310", Offset = "0x3CB7510", VA = "0x183CB8310")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3CB82E0", Offset = "0x3CB74E0", VA = "0x183CB82E0")]
		public SerializedMutableOverridableObscuredEnum(bool ILCKLMFHNBD, TObsEnum ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7FE0", Offset = "0x3CB71E0", VA = "0x183CB7FE0", Slot = "18")]
		public sealed override HHENNJECBLH ANAJLIEIKDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3CB81C0", Offset = "0x3CB73C0", VA = "0x183CB81C0", Slot = "19")]
		public sealed override void ICMKANAEANP(HHENNJECBLH LGJPMIDIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8110", Offset = "0x3CB7310", VA = "0x183CB8110", Slot = "20")]
		public sealed override void EOMGBDBAHDG(byte[] ONGOKCMMCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB80B0", Offset = "0x3CB72B0", VA = "0x183CB80B0", Slot = "17")]
		public sealed override void BLKLFBLJHAF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, EFIODIDLLDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1583C70", Offset = "0x1582E70", VA = "0x181583C70", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1583CB0", Offset = "0x1582EB0", VA = "0x181583CB0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1583B80", Offset = "0x1582D80", VA = "0x181583B80")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1583C10", Offset = "0x1582E10", VA = "0x181583C10")]
		public MutableOverridableListObscuredString(bool ILCKLMFHNBD, List<ObscuredString> ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1583AE0", Offset = "0x1582CE0", VA = "0x181583AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15836A0", Offset = "0x15828A0", VA = "0x1815836A0", Slot = "17")]
		public override void BLKLFBLJHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1583710", Offset = "0x1582910", VA = "0x181583710", Slot = "20")]
		public override void EOMGBDBAHDG(byte[] ONGOKCMMCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x15837C0", Offset = "0x15829C0", VA = "0x1815837C0", Slot = "19")]
		public override void ICMKANAEANP(EFIODIDLLDB LGJPMIDIPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x15834C0", Offset = "0x15826C0", VA = "0x1815834C0", Slot = "18")]
		public override EFIODIDLLDB ANAJLIEIKDG()
		{
			return null;
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
