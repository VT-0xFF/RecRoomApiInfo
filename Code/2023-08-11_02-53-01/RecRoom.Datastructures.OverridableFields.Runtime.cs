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
public interface LDFMJICMCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ALEFOEAINKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AGDBGBDEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GGPKMPHEHPN<T> : LDFMJICMCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GPJIAAEPLKO<T> : GGPKMPHEHPN<T>, LDFMJICMCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool ALEFOEAINKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T PGHJLABHLGJ
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
public interface FMMAJAACICI<T> : GPJIAAEPLKO<T>, GGPKMPHEHPN<T>, LDFMJICMCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KJKADELONLK
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
	public struct OverridableVector3 : GGPKMPHEHPN<Vector3>, LDFMJICMCBD
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
			[Cpp2IlInjected.Address(RVA = "0x4517FE0", Offset = "0x45167E0", VA = "0x184517FE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF9390", Offset = "0x6EF7B90", VA = "0x186EF9390", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF93E0", Offset = "0x6EF7BE0", VA = "0x186EF93E0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9370", Offset = "0x6EF7B70", VA = "0x186EF9370")]
		public OverridableVector3(Vector3 MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF92D0", Offset = "0x6EF7AD0", VA = "0x186EF92D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF92A0", Offset = "0x6EF7AA0", VA = "0x186EF92A0")]
		public static OverridableVector3 HFMFJLJFEMO(Vector3 BNMGNDJJNJM)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : GGPKMPHEHPN<int>, LDFMJICMCBD
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
			[Cpp2IlInjected.Address(RVA = "0x4517FE0", Offset = "0x45167E0", VA = "0x184517FE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6EF91E0", Offset = "0x6EF79E0", VA = "0x186EF91E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2335FD0", Offset = "0x23347D0", VA = "0x182335FD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9140", Offset = "0x6EF7940", VA = "0x186EF9140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : GGPKMPHEHPN<string>, LDFMJICMCBD
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
			[Cpp2IlInjected.Address(RVA = "0x4517FE0", Offset = "0x45167E0", VA = "0x184517FE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3AC1E50", Offset = "0x3AC0650", VA = "0x183AC1E50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3AC1E50", Offset = "0x3AC0650", VA = "0x183AC1E50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9230", Offset = "0x6EF7A30", VA = "0x186EF9230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GPJIAAEPLKO<InnerType>, GGPKMPHEHPN<InnerType>, LDFMJICMCBD where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool ALEFOEAINKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType PGHJLABHLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object AGDBGBDEDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1F02730", Offset = "0x1F00F30", VA = "0x181F02730", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2E35BF0", Offset = "0x2E343F0", VA = "0x182E35BF0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2E35CB0", Offset = "0x2E344B0", VA = "0x182E35CB0")]
		public MutableOverridableBase(bool OGECMJNDJJE, [NotNull] InnerType MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E358B0", Offset = "0x2E340B0", VA = "0x182E358B0", Slot = "15")]
		public void DLPPLJJPEKC(GGPKMPHEHPN<InnerType> DEOKJFCFEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2E35160", Offset = "0x2E33960", VA = "0x182E35160", Slot = "16")]
		public void BBGJPJPLCPO(GGPKMPHEHPN<InnerType> OALEAAIPGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2E35A90", Offset = "0x2E34290", VA = "0x182E35A90", Slot = "17")]
		public virtual void OGPDBFFONOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType FOBKACAPNOI();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JNHCBGLEBHB(ProtobufType DBJHLFILLOC);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DDBLGMDIEBC(byte[] CJBIEPGCBJD);
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
			[Cpp2IlInjected.Address(RVA = "0xF70F20", Offset = "0xF6F720", VA = "0x180F70F20", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x97D930", Offset = "0x97C130", VA = "0x18097D930", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA48BE0", Offset = "0xA473E0", VA = "0x180A48BE0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x147D100", Offset = "0x147B900", VA = "0x18147D100", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCEBD20", Offset = "0xCEA520", VA = "0x180CEBD20")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x21FA990", Offset = "0x21F9190", VA = "0x1821FA990")]
		public SerializedMutableOverridableBase(bool OGECMJNDJJE, InnerType MENBIMCLIOI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PNBJJANOIKI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF90E0", Offset = "0x6EF78E0", VA = "0x186EF90E0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9070", Offset = "0x6EF7870", VA = "0x186EF9070")]
		public MutableOverridableObscuredInt(bool OGECMJNDJJE, ObscuredInt MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8FA0", Offset = "0x6EF77A0", VA = "0x186EF8FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D20", Offset = "0x6EF7520", VA = "0x186EF8D20", Slot = "20")]
		public override void DDBLGMDIEBC(byte[] CJBIEPGCBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8ED0", Offset = "0x6EF76D0", VA = "0x186EF8ED0", Slot = "19")]
		public override void JNHCBGLEBHB(PNBJJANOIKI DBJHLFILLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8DD0", Offset = "0x6EF75D0", VA = "0x186EF8DD0", Slot = "18")]
		public override PNBJJANOIKI FOBKACAPNOI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, FIJLPKHBBFD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8C50", Offset = "0x6EF7450", VA = "0x186EF8C50")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8CB0", Offset = "0x6EF74B0", VA = "0x186EF8CB0")]
		public MutableOverridableObscuredFloat(bool OGECMJNDJJE, ObscuredFloat MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8B80", Offset = "0x6EF7380", VA = "0x186EF8B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EF88E0", Offset = "0x6EF70E0", VA = "0x186EF88E0", Slot = "20")]
		public override void DDBLGMDIEBC(byte[] CJBIEPGCBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8AA0", Offset = "0x6EF72A0", VA = "0x186EF8AA0", Slot = "19")]
		public override void JNHCBGLEBHB(FIJLPKHBBFD DBJHLFILLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8990", Offset = "0x6EF7190", VA = "0x186EF8990", Slot = "18")]
		public override FIJLPKHBBFD FOBKACAPNOI()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LNCMMNMGJHE>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7BD0", Offset = "0x6EF63D0", VA = "0x186EF7BD0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8870", Offset = "0x6EF7070", VA = "0x186EF8870")]
		public MutableOverridableObscuredBool(bool OGECMJNDJJE, ObscuredBool MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EF87A0", Offset = "0x6EF6FA0", VA = "0x186EF87A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EF84C0", Offset = "0x6EF6CC0", VA = "0x186EF84C0", Slot = "20")]
		public override void DDBLGMDIEBC(byte[] CJBIEPGCBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8670", Offset = "0x6EF6E70", VA = "0x186EF8670", Slot = "19")]
		public override void JNHCBGLEBHB(LNCMMNMGJHE DBJHLFILLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8570", Offset = "0x6EF6D70", VA = "0x186EF8570", Slot = "18")]
		public override LNCMMNMGJHE FOBKACAPNOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8750", Offset = "0x6EF6F50", VA = "0x186EF8750", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, FMMAJAACICI<ObscuredBool>, GPJIAAEPLKO<ObscuredBool>, GGPKMPHEHPN<ObscuredBool>, LDFMJICMCBD
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA976F0", VA = "0x180A98EF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA991D0", Offset = "0xA979D0", VA = "0x180A991D0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7BD0", Offset = "0x6EF63D0", VA = "0x186EF7BD0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7B50", Offset = "0x6EF6350", VA = "0x186EF7B50")]
		public void DLPPLJJPEKC(MutableOverridableDefaultableObscuredBool OALEAAIPGBP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PNBJJANOIKI> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x343FDE0", Offset = "0x343E5E0", VA = "0x18343FDE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x343FEC0", Offset = "0x343E6C0", VA = "0x18343FEC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2032050", Offset = "0x2030850", VA = "0x182032050")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x343FDB0", Offset = "0x343E5B0", VA = "0x18343FDB0")]
		public SerializedMutableOverridableObscuredEnum(bool OGECMJNDJJE, TObsEnum MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x343FB60", Offset = "0x343E360", VA = "0x18343FB60", Slot = "18")]
		public sealed override PNBJJANOIKI FOBKACAPNOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x343FC30", Offset = "0x343E430", VA = "0x18343FC30", Slot = "19")]
		public sealed override void JNHCBGLEBHB(PNBJJANOIKI DBJHLFILLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x343FAB0", Offset = "0x343E2B0", VA = "0x18343FAB0", Slot = "20")]
		public sealed override void DDBLGMDIEBC(byte[] CJBIEPGCBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x343FD50", Offset = "0x343E550", VA = "0x18343FD50", Slot = "17")]
		public sealed override void OGPDBFFONOJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, IPPBHKENJHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF83F0", Offset = "0x6EF6BF0", VA = "0x186EF83F0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8430", Offset = "0x6EF6C30", VA = "0x186EF8430", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8300", Offset = "0x6EF6B00", VA = "0x186EF8300")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8390", Offset = "0x6EF6B90", VA = "0x186EF8390")]
		public MutableOverridableListObscuredString(bool OGECMJNDJJE, List<ObscuredString> MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8260", Offset = "0x6EF6A60", VA = "0x186EF8260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF81F0", Offset = "0x6EF69F0", VA = "0x186EF81F0", Slot = "17")]
		public override void OGPDBFFONOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7C40", Offset = "0x6EF6440", VA = "0x186EF7C40", Slot = "20")]
		public override void DDBLGMDIEBC(byte[] CJBIEPGCBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7ED0", Offset = "0x6EF66D0", VA = "0x186EF7ED0", Slot = "19")]
		public override void JNHCBGLEBHB(IPPBHKENJHP DBJHLFILLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7CF0", Offset = "0x6EF64F0", VA = "0x186EF7CF0", Slot = "18")]
		public override IPPBHKENJHP FOBKACAPNOI()
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
