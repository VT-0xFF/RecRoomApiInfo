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
public interface IAMICBNPICF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DKPICBMBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object LDIKGINHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LGOGGONANHO<T> : IAMICBNPICF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DPBPDOFHNEH<T> : LGOGGONANHO<T>, IAMICBNPICF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool DKPICBMBNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T EKGBCCDIAJC
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
public interface MEJMJHJOLPG<T> : DPBPDOFHNEH<T>, LGOGGONANHO<T>, IAMICBNPICF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KJKEDIHNIFA
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
	public struct OverridableVector3 : LGOGGONANHO<Vector3>, IAMICBNPICF
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
			[Cpp2IlInjected.Address(RVA = "0x5082380", Offset = "0x5081780", VA = "0x185082380", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x72000D0", Offset = "0x71FF4D0", VA = "0x1872000D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7200120", Offset = "0x71FF520", VA = "0x187200120", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72000B0", Offset = "0x71FF4B0", VA = "0x1872000B0")]
		public OverridableVector3(Vector3 AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7200010", Offset = "0x71FF410", VA = "0x187200010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71FFFE0", Offset = "0x71FF3E0", VA = "0x1871FFFE0")]
		public static OverridableVector3 LFFBPOODCDC(Vector3 GBFJPNOAMDK)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : LGOGGONANHO<int>, IAMICBNPICF
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
			[Cpp2IlInjected.Address(RVA = "0x5082380", Offset = "0x5081780", VA = "0x185082380", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x71FFF20", Offset = "0x71FF320", VA = "0x1871FFF20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2898E40", Offset = "0x2898240", VA = "0x182898E40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71FFE80", Offset = "0x71FF280", VA = "0x1871FFE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : LGOGGONANHO<string>, IAMICBNPICF
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
			[Cpp2IlInjected.Address(RVA = "0x5082380", Offset = "0x5081780", VA = "0x185082380", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EF90", Offset = "0x3C8E390", VA = "0x183C8EF90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3C8EF90", Offset = "0x3C8E390", VA = "0x183C8EF90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71FFF70", Offset = "0x71FF370", VA = "0x1871FFF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : DPBPDOFHNEH<InnerType>, LGOGGONANHO<InnerType>, IAMICBNPICF where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool DKPICBMBNCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType EKGBCCDIAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object LDIKGINHFFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1D3AA00", Offset = "0x1D39E00", VA = "0x181D3AA00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A770", Offset = "0x1D39B70", VA = "0x181D3A770")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A830", Offset = "0x1D39C30", VA = "0x181D3A830")]
		public MutableOverridableBase(bool CLODBNNBOGC, [NotNull] InnerType AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D39DC0", Offset = "0x1D391C0", VA = "0x181D39DC0", Slot = "15")]
		public void CJANLLJCDGE(LGOGGONANHO<InnerType> AAPFHDLOBGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A2F0", Offset = "0x1D396F0", VA = "0x181D3A2F0", Slot = "16")]
		public void EMCLIHJFPMF(LGOGGONANHO<InnerType> ICELKIGIKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A610", Offset = "0x1D39A10", VA = "0x181D3A610", Slot = "17")]
		public virtual void IKCBOKMOGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CBDGBNHFKOC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void MMDDJAEJDDB(ProtobufType KJDGDJGKHPG);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void GIFKJMPADCM(byte[] JGHJHPJEICL);
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
			[Cpp2IlInjected.Address(RVA = "0xB78270", Offset = "0xB77670", VA = "0x180B78270", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8C1870", Offset = "0x8C0C70", VA = "0x1808C1870", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9C56F0", Offset = "0x9C4AF0", VA = "0x1809C56F0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12888F0", Offset = "0x1287CF0", VA = "0x1812888F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1016C80", Offset = "0x1016080", VA = "0x181016C80")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1306BF0", Offset = "0x1305FF0", VA = "0x181306BF0")]
		public SerializedMutableOverridableBase(bool CLODBNNBOGC, InnerType AGLCIEKHLEE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, DPIADEAMFEF>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71FFE20", Offset = "0x71FF220", VA = "0x1871FFE20")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71FFDB0", Offset = "0x71FF1B0", VA = "0x1871FFDB0")]
		public MutableOverridableObscuredInt(bool CLODBNNBOGC, ObscuredInt AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71FFCE0", Offset = "0x71FF0E0", VA = "0x1871FFCE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71FFB60", Offset = "0x71FEF60", VA = "0x1871FFB60", Slot = "20")]
		public override void GIFKJMPADCM(byte[] JGHJHPJEICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71FFC10", Offset = "0x71FF010", VA = "0x1871FFC10", Slot = "19")]
		public override void MMDDJAEJDDB(DPIADEAMFEF KJDGDJGKHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71FFA60", Offset = "0x71FEE60", VA = "0x1871FFA60", Slot = "18")]
		public override DPIADEAMFEF CBDGBNHFKOC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DBDNMNALGOA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71FF990", Offset = "0x71FED90", VA = "0x1871FF990")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71FF9F0", Offset = "0x71FEDF0", VA = "0x1871FF9F0")]
		public MutableOverridableObscuredFloat(bool CLODBNNBOGC, ObscuredFloat AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71FF8C0", Offset = "0x71FECC0", VA = "0x1871FF8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71FF730", Offset = "0x71FEB30", VA = "0x1871FF730", Slot = "20")]
		public override void GIFKJMPADCM(byte[] JGHJHPJEICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71FF7E0", Offset = "0x71FEBE0", VA = "0x1871FF7E0", Slot = "19")]
		public override void MMDDJAEJDDB(DBDNMNALGOA KJDGDJGKHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x71FF620", Offset = "0x71FEA20", VA = "0x1871FF620", Slot = "18")]
		public override DBDNMNALGOA CBDGBNHFKOC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, IFGCIKCNPPH>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71FE910", Offset = "0x71FDD10", VA = "0x1871FE910")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71FF5B0", Offset = "0x71FE9B0", VA = "0x1871FF5B0")]
		public MutableOverridableObscuredBool(bool CLODBNNBOGC, ObscuredBool AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71FF4E0", Offset = "0x71FE8E0", VA = "0x1871FF4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71FF300", Offset = "0x71FE700", VA = "0x1871FF300", Slot = "20")]
		public override void GIFKJMPADCM(byte[] JGHJHPJEICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x71FF3B0", Offset = "0x71FE7B0", VA = "0x1871FF3B0", Slot = "19")]
		public override void MMDDJAEJDDB(IFGCIKCNPPH KJDGDJGKHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71FF200", Offset = "0x71FE600", VA = "0x1871FF200", Slot = "18")]
		public override IFGCIKCNPPH CBDGBNHFKOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71FF490", Offset = "0x71FE890", VA = "0x1871FF490", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, MEJMJHJOLPG<ObscuredBool>, DPBPDOFHNEH<ObscuredBool>, LGOGGONANHO<ObscuredBool>, IAMICBNPICF
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5070", Offset = "0x8C4470", VA = "0x1808C5070", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8C50E0", Offset = "0x8C44E0", VA = "0x1808C50E0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71FE910", Offset = "0x71FDD10", VA = "0x1871FE910")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71FE890", Offset = "0x71FDC90", VA = "0x1871FE890")]
		public void CJANLLJCDGE(MutableOverridableDefaultableObscuredBool ICELKIGIKKP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, DPIADEAMFEF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x44C5DC0", Offset = "0x44C51C0", VA = "0x1844C5DC0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x44C5EA0", Offset = "0x44C52A0", VA = "0x1844C5EA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x22FB500", Offset = "0x22FA900", VA = "0x1822FB500")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x44C5D90", Offset = "0x44C5190", VA = "0x1844C5D90")]
		public SerializedMutableOverridableObscuredEnum(bool CLODBNNBOGC, TObsEnum AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x44C5A90", Offset = "0x44C4E90", VA = "0x1844C5A90", Slot = "18")]
		public sealed override DPIADEAMFEF CBDGBNHFKOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x44C5C70", Offset = "0x44C5070", VA = "0x1844C5C70", Slot = "19")]
		public sealed override void MMDDJAEJDDB(DPIADEAMFEF KJDGDJGKHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44C5B60", Offset = "0x44C4F60", VA = "0x1844C5B60", Slot = "20")]
		public sealed override void GIFKJMPADCM(byte[] JGHJHPJEICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x44C5C10", Offset = "0x44C5010", VA = "0x1844C5C10", Slot = "17")]
		public sealed override void IKCBOKMOGJK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, NMIGEIBPGIM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71FF130", Offset = "0x71FE530", VA = "0x1871FF130", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x71FF170", Offset = "0x71FE570", VA = "0x1871FF170", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71FF040", Offset = "0x71FE440", VA = "0x1871FF040")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71FF0D0", Offset = "0x71FE4D0", VA = "0x1871FF0D0")]
		public MutableOverridableListObscuredString(bool CLODBNNBOGC, List<ObscuredString> AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71FEFA0", Offset = "0x71FE3A0", VA = "0x1871FEFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71FEC10", Offset = "0x71FE010", VA = "0x1871FEC10", Slot = "17")]
		public override void IKCBOKMOGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71FEB60", Offset = "0x71FDF60", VA = "0x1871FEB60", Slot = "20")]
		public override void GIFKJMPADCM(byte[] JGHJHPJEICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71FEC80", Offset = "0x71FE080", VA = "0x1871FEC80", Slot = "19")]
		public override void MMDDJAEJDDB(NMIGEIBPGIM KJDGDJGKHPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71FE980", Offset = "0x71FDD80", VA = "0x1871FE980", Slot = "18")]
		public override NMIGEIBPGIM CBDGBNHFKOC()
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
