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
public interface OHGLDEABAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CCPHIANLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AJINEBFJBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EILMIFBPHPF<T> : OHGLDEABAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KPGNKGMOACK<T> : EILMIFBPHPF<T>, OHGLDEABAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CCPHIANLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T MHGNIJCIFFL
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
public interface LBFGEBFNFCG<T> : KPGNKGMOACK<T>, EILMIFBPHPF<T>, OHGLDEABAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MDFFEAFPBLI
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
	public struct OverridableVector3 : EILMIFBPHPF<Vector3>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x139DB30", Offset = "0x139C730", VA = "0x18139DB30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FD5040", Offset = "0x6FD3C40", VA = "0x186FD5040", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FD5090", Offset = "0x6FD3C90", VA = "0x186FD5090", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5020", Offset = "0x6FD3C20", VA = "0x186FD5020")]
		public OverridableVector3(Vector3 ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4F80", Offset = "0x6FD3B80", VA = "0x186FD4F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4F50", Offset = "0x6FD3B50", VA = "0x186FD4F50")]
		public static OverridableVector3 DGIADCHILCD(Vector3 FOHLJCNEPNC)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : EILMIFBPHPF<int>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x139DB30", Offset = "0x139C730", VA = "0x18139DB30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FD4E90", Offset = "0x6FD3A90", VA = "0x186FD4E90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB1B670", Offset = "0xB1A270", VA = "0x180B1B670", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4DF0", Offset = "0x6FD39F0", VA = "0x186FD4DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : EILMIFBPHPF<string>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x139DB30", Offset = "0x139C730", VA = "0x18139DB30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC9E960", Offset = "0xC9D560", VA = "0x180C9E960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC9E960", Offset = "0xC9D560", VA = "0x180C9E960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4EE0", Offset = "0x6FD3AE0", VA = "0x186FD4EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KPGNKGMOACK<InnerType>, EILMIFBPHPF<InnerType>, OHGLDEABAHN where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool CCPHIANLIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object AJINEBFJBPC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2978910", Offset = "0x2977510", VA = "0x182978910", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2F80DD0", Offset = "0x2F7F9D0", VA = "0x182F80DD0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2F80E90", Offset = "0x2F7FA90", VA = "0x182F80E90")]
		public MutableOverridableBase(bool LOKMACHDPKB, [NotNull] InnerType ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2F808B0", Offset = "0x2F7F4B0", VA = "0x182F808B0", Slot = "15")]
		public void NGIJMOCGGED(EILMIFBPHPF<InnerType> IPOAGOJOAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2F80700", Offset = "0x2F7F300", VA = "0x182F80700", Slot = "16")]
		public void BOIMNMIKDGA(EILMIFBPHPF<InnerType> MDHJAFNLPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2F80C10", Offset = "0x2F7F810", VA = "0x182F80C10", Slot = "17")]
		public virtual void NHGHFKAFNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType FEADFCNPGMN();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void NLDLIJGKDGI(ProtobufType MJJEAGOMNNL);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void OFEECHBHOJJ(byte[] COIIHAMCHMJ);
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
			[Cpp2IlInjected.Address(RVA = "0xDF50D0", Offset = "0xDF3CD0", VA = "0x180DF50D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x913A80", Offset = "0x912680", VA = "0x180913A80", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9897A0", Offset = "0x9883A0", VA = "0x1809897A0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x18F56E0", Offset = "0x18F42E0", VA = "0x1818F56E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14FE3C0", Offset = "0x14FCFC0", VA = "0x1814FE3C0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A423E0", Offset = "0x2A40FE0", VA = "0x182A423E0")]
		public SerializedMutableOverridableBase(bool LOKMACHDPKB, InnerType ECNGHFJBIJL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HKEIMINHNON>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4D90", Offset = "0x6FD3990", VA = "0x186FD4D90")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4D20", Offset = "0x6FD3920", VA = "0x186FD4D20")]
		public MutableOverridableObscuredInt(bool LOKMACHDPKB, ObscuredInt ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4C50", Offset = "0x6FD3850", VA = "0x186FD4C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4BA0", Offset = "0x6FD37A0", VA = "0x186FD4BA0", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4AD0", Offset = "0x6FD36D0", VA = "0x186FD4AD0", Slot = "19")]
		public override void NLDLIJGKDGI(HKEIMINHNON MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD49D0", Offset = "0x6FD35D0", VA = "0x186FD49D0", Slot = "18")]
		public override HKEIMINHNON FEADFCNPGMN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, DLLHDIHOFGK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4900", Offset = "0x6FD3500", VA = "0x186FD4900")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4960", Offset = "0x6FD3560", VA = "0x186FD4960")]
		public MutableOverridableObscuredFloat(bool LOKMACHDPKB, ObscuredFloat ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4830", Offset = "0x6FD3430", VA = "0x186FD4830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4780", Offset = "0x6FD3380", VA = "0x186FD4780", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6FD46A0", Offset = "0x6FD32A0", VA = "0x186FD46A0", Slot = "19")]
		public override void NLDLIJGKDGI(DLLHDIHOFGK MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4590", Offset = "0x6FD3190", VA = "0x186FD4590", Slot = "18")]
		public override DLLHDIHOFGK FEADFCNPGMN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, HFLPPJEOCHJ>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3890", Offset = "0x6FD2490", VA = "0x186FD3890")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4520", Offset = "0x6FD3120", VA = "0x186FD4520")]
		public MutableOverridableObscuredBool(bool LOKMACHDPKB, ObscuredBool ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4450", Offset = "0x6FD3050", VA = "0x186FD4450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4360", Offset = "0x6FD2F60", VA = "0x186FD4360", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4280", Offset = "0x6FD2E80", VA = "0x186FD4280", Slot = "19")]
		public override void NLDLIJGKDGI(HFLPPJEOCHJ MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4180", Offset = "0x6FD2D80", VA = "0x186FD4180", Slot = "18")]
		public override HFLPPJEOCHJ FEADFCNPGMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4410", Offset = "0x6FD3010", VA = "0x186FD4410", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, LBFGEBFNFCG<ObscuredBool>, KPGNKGMOACK<ObscuredBool>, EILMIFBPHPF<ObscuredBool>, OHGLDEABAHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83DCF0", Offset = "0x83C8F0", VA = "0x18083DCF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAFFCA0", Offset = "0xAFE8A0", VA = "0x180AFFCA0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3890", Offset = "0x6FD2490", VA = "0x186FD3890")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3810", Offset = "0x6FD2410", VA = "0x186FD3810")]
		public void NGIJMOCGGED(MutableOverridableDefaultableObscuredBool MDHJAFNLPON)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HKEIMINHNON> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x42A85A0", Offset = "0x42A71A0", VA = "0x1842A85A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x42A8680", Offset = "0x42A7280", VA = "0x1842A8680", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1C76AA0", Offset = "0x1C756A0", VA = "0x181C76AA0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x42A8570", Offset = "0x42A7170", VA = "0x1842A8570")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3575D00", Offset = "0x3574900", VA = "0x183575D00")]
		public SerializedMutableOverridableObscuredEnum(bool LOKMACHDPKB, TObsEnum ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42A8270", Offset = "0x42A6E70", VA = "0x1842A8270", Slot = "18")]
		public sealed override HKEIMINHNON FEADFCNPGMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x42A83A0", Offset = "0x42A6FA0", VA = "0x1842A83A0", Slot = "19")]
		public sealed override void NLDLIJGKDGI(HKEIMINHNON MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x42A84C0", Offset = "0x42A70C0", VA = "0x1842A84C0", Slot = "20")]
		public sealed override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42A8340", Offset = "0x42A6F40", VA = "0x1842A8340", Slot = "17")]
		public sealed override void NHGHFKAFNCD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, ECFAIGCFENC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FD40B0", Offset = "0x6FD2CB0", VA = "0x186FD40B0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FD40F0", Offset = "0x6FD2CF0", VA = "0x186FD40F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3FC0", Offset = "0x6FD2BC0", VA = "0x186FD3FC0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4050", Offset = "0x6FD2C50", VA = "0x186FD4050")]
		public MutableOverridableListObscuredString(bool LOKMACHDPKB, List<ObscuredString> ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3F20", Offset = "0x6FD2B20", VA = "0x186FD3F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3AE0", Offset = "0x6FD26E0", VA = "0x186FD3AE0", Slot = "17")]
		public override void NHGHFKAFNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E70", Offset = "0x6FD2A70", VA = "0x186FD3E70", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3B50", Offset = "0x6FD2750", VA = "0x186FD3B50", Slot = "19")]
		public override void NLDLIJGKDGI(ECFAIGCFENC MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3900", Offset = "0x6FD2500", VA = "0x186FD3900", Slot = "18")]
		public override ECFAIGCFENC FEADFCNPGMN()
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
