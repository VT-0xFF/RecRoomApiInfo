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
public interface KPGNKGMOACK<T> : global::EILMIFBPHPF<T>, OHGLDEABAHN
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
public interface LBFGEBFNFCG<T> : global::KPGNKGMOACK<T>, global::EILMIFBPHPF<T>, OHGLDEABAHN
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
	public struct OverridableVector3 : global::EILMIFBPHPF<Vector3>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x15E7DD0", Offset = "0x15E69D0", VA = "0x1815E7DD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5280", Offset = "0x6FC3E80", VA = "0x186FC5280", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC52D0", Offset = "0x6FC3ED0", VA = "0x186FC52D0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5260", Offset = "0x6FC3E60", VA = "0x186FC5260")]
		public OverridableVector3(Vector3 ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC51C0", Offset = "0x6FC3DC0", VA = "0x186FC51C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5190", Offset = "0x6FC3D90", VA = "0x186FC5190")]
		public static OverridableVector3 DGIADCHILCD(Vector3 FOHLJCNEPNC)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : global::EILMIFBPHPF<int>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x15E7DD0", Offset = "0x15E69D0", VA = "0x1815E7DD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FC50D0", Offset = "0x6FC3CD0", VA = "0x186FC50D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB91F70", Offset = "0xB90B70", VA = "0x180B91F70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5030", Offset = "0x6FC3C30", VA = "0x186FC5030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : global::EILMIFBPHPF<string>, OHGLDEABAHN
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
			[Cpp2IlInjected.Address(RVA = "0x15E7DD0", Offset = "0x15E69D0", VA = "0x1815E7DD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD49F20", Offset = "0xD48B20", VA = "0x180D49F20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD49F20", Offset = "0xD48B20", VA = "0x180D49F20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5120", Offset = "0x6FC3D20", VA = "0x186FC5120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::KPGNKGMOACK<InnerType>, global::EILMIFBPHPF<InnerType>, OHGLDEABAHN where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
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
			[Cpp2IlInjected.Address(RVA = "0x2935EB0", Offset = "0x2934AB0", VA = "0x182935EB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2935C20", Offset = "0x2934820", VA = "0x182935C20")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2935CE0", Offset = "0x29348E0", VA = "0x182935CE0")]
		public MutableOverridableBase(bool LOKMACHDPKB, [NotNull] InnerType ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29357F0", Offset = "0x29343F0", VA = "0x1829357F0", Slot = "15")]
		public void NGIJMOCGGED(global::EILMIFBPHPF<InnerType> IPOAGOJOAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2935190", Offset = "0x2933D90", VA = "0x182935190", Slot = "16")]
		public void BOIMNMIKDGA(global::EILMIFBPHPF<InnerType> MDHJAFNLPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2935A60", Offset = "0x2934660", VA = "0x182935A60", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0xC23F10", Offset = "0xC22B10", VA = "0x180C23F10", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83B800", Offset = "0x83A400", VA = "0x18083B800", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x945B70", Offset = "0x944770", VA = "0x180945B70", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1DCEC30", Offset = "0x1DCD830", VA = "0x181DCEC30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1701F20", Offset = "0x1700B20", VA = "0x181701F20")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E810", Offset = "0x1B9D410", VA = "0x181B9E810")]
		public SerializedMutableOverridableBase(bool LOKMACHDPKB, InnerType ECNGHFJBIJL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HKEIMINHNON>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4FD0", Offset = "0x6FC3BD0", VA = "0x186FC4FD0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4F60", Offset = "0x6FC3B60", VA = "0x186FC4F60")]
		public MutableOverridableObscuredInt(bool LOKMACHDPKB, ObscuredInt ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4E90", Offset = "0x6FC3A90", VA = "0x186FC4E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4DE0", Offset = "0x6FC39E0", VA = "0x186FC4DE0", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4D10", Offset = "0x6FC3910", VA = "0x186FC4D10", Slot = "19")]
		public override void NLDLIJGKDGI(HKEIMINHNON MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4C10", Offset = "0x6FC3810", VA = "0x186FC4C10", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FC4B40", Offset = "0x6FC3740", VA = "0x186FC4B40")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4BA0", Offset = "0x6FC37A0", VA = "0x186FC4BA0")]
		public MutableOverridableObscuredFloat(bool LOKMACHDPKB, ObscuredFloat ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4A70", Offset = "0x6FC3670", VA = "0x186FC4A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FC49C0", Offset = "0x6FC35C0", VA = "0x186FC49C0", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6FC48E0", Offset = "0x6FC34E0", VA = "0x186FC48E0", Slot = "19")]
		public override void NLDLIJGKDGI(DLLHDIHOFGK MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FC47D0", Offset = "0x6FC33D0", VA = "0x186FC47D0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FC3AD0", Offset = "0x6FC26D0", VA = "0x186FC3AD0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4760", Offset = "0x6FC3360", VA = "0x186FC4760")]
		public MutableOverridableObscuredBool(bool LOKMACHDPKB, ObscuredBool ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4690", Offset = "0x6FC3290", VA = "0x186FC4690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FC45A0", Offset = "0x6FC31A0", VA = "0x186FC45A0", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC44C0", Offset = "0x6FC30C0", VA = "0x186FC44C0", Slot = "19")]
		public override void NLDLIJGKDGI(HFLPPJEOCHJ MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC43C0", Offset = "0x6FC2FC0", VA = "0x186FC43C0", Slot = "18")]
		public override HFLPPJEOCHJ FEADFCNPGMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4650", Offset = "0x6FC3250", VA = "0x186FC4650", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::LBFGEBFNFCG<ObscuredBool>, global::KPGNKGMOACK<ObscuredBool>, global::EILMIFBPHPF<ObscuredBool>, OHGLDEABAHN
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x852430", Offset = "0x851030", VA = "0x180852430", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8E5990", Offset = "0x8E4590", VA = "0x1808E5990", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3AD0", Offset = "0x6FC26D0", VA = "0x186FC3AD0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3A50", Offset = "0x6FC2650", VA = "0x186FC3A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x455CB60", Offset = "0x455B760", VA = "0x18455CB60", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x455CC40", Offset = "0x455B840", VA = "0x18455CC40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F430", Offset = "0x1A0E030", VA = "0x181A0F430")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x455CB30", Offset = "0x455B730", VA = "0x18455CB30")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D130", Offset = "0x3D0BD30", VA = "0x183D0D130")]
		public SerializedMutableOverridableObscuredEnum(bool LOKMACHDPKB, TObsEnum ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x455C830", Offset = "0x455B430", VA = "0x18455C830", Slot = "18")]
		public sealed override HKEIMINHNON FEADFCNPGMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x455C960", Offset = "0x455B560", VA = "0x18455C960", Slot = "19")]
		public sealed override void NLDLIJGKDGI(HKEIMINHNON MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x455CA80", Offset = "0x455B680", VA = "0x18455CA80", Slot = "20")]
		public sealed override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x455C900", Offset = "0x455B500", VA = "0x18455C900", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FC42F0", Offset = "0x6FC2EF0", VA = "0x186FC42F0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC4330", Offset = "0x6FC2F30", VA = "0x186FC4330", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4200", Offset = "0x6FC2E00", VA = "0x186FC4200")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4290", Offset = "0x6FC2E90", VA = "0x186FC4290")]
		public MutableOverridableListObscuredString(bool LOKMACHDPKB, List<ObscuredString> ECNGHFJBIJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4160", Offset = "0x6FC2D60", VA = "0x186FC4160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3D20", Offset = "0x6FC2920", VA = "0x186FC3D20", Slot = "17")]
		public override void NHGHFKAFNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FC40B0", Offset = "0x6FC2CB0", VA = "0x186FC40B0", Slot = "20")]
		public override void OFEECHBHOJJ(byte[] COIIHAMCHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3D90", Offset = "0x6FC2990", VA = "0x186FC3D90", Slot = "19")]
		public override void NLDLIJGKDGI(ECFAIGCFENC MJJEAGOMNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3B40", Offset = "0x6FC2740", VA = "0x186FC3B40", Slot = "18")]
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
