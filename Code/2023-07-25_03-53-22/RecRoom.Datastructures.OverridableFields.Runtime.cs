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
public interface OCLGENBLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BBHGIAOFGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object OADCPKPDMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MBPNHJDPPEH<T> : OCLGENBLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PDJBJIIDIAI<T> : MBPNHJDPPEH<T>, OCLGENBLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool BBHGIAOFGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FNCIDNAOCJJ
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
public interface BEBEGGIHPFC<T> : PDJBJIIDIAI<T>, MBPNHJDPPEH<T>, OCLGENBLEGP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OMOJGKOOMNK
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
	public struct OverridableVector3 : MBPNHJDPPEH<Vector3>, OCLGENBLEGP
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
			[Cpp2IlInjected.Address(RVA = "0xA8B080", Offset = "0xA8A080", VA = "0x180A8B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x72DB470", Offset = "0x72DA470", VA = "0x1872DB470", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x72DB4C0", Offset = "0x72DA4C0", VA = "0x1872DB4C0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72DB450", Offset = "0x72DA450", VA = "0x1872DB450")]
		public OverridableVector3(Vector3 CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72DB3B0", Offset = "0x72DA3B0", VA = "0x1872DB3B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72DB380", Offset = "0x72DA380", VA = "0x1872DB380")]
		public static OverridableVector3 MGOLCJODLKK(Vector3 HLLJGNGJMBM)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : MBPNHJDPPEH<int>, OCLGENBLEGP
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
			[Cpp2IlInjected.Address(RVA = "0xA8B080", Offset = "0xA8A080", VA = "0x180A8B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72DB2C0", Offset = "0x72DA2C0", VA = "0x1872DB2C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xFCF0E0", Offset = "0xFCE0E0", VA = "0x180FCF0E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72DB220", Offset = "0x72DA220", VA = "0x1872DB220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : MBPNHJDPPEH<string>, OCLGENBLEGP
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
			[Cpp2IlInjected.Address(RVA = "0xA8B080", Offset = "0xA8A080", VA = "0x180A8B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x11511C0", Offset = "0x11501C0", VA = "0x1811511C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x11511C0", Offset = "0x11501C0", VA = "0x1811511C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72DB310", Offset = "0x72DA310", VA = "0x1872DB310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : PDJBJIIDIAI<InnerType>, MBPNHJDPPEH<InnerType>, OCLGENBLEGP where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool BBHGIAOFGDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType FNCIDNAOCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object OADCPKPDMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x226B290", Offset = "0x226A290", VA = "0x18226B290", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2975DC0", Offset = "0x2974DC0", VA = "0x182975DC0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2975E80", Offset = "0x2974E80", VA = "0x182975E80")]
		public MutableOverridableBase(bool AANDEMIALKC, [NotNull] InnerType CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2975330", Offset = "0x2974330", VA = "0x182975330", Slot = "15")]
		public void CKPDLHEMEGA(MBPNHJDPPEH<InnerType> KFCADKDKPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2975800", Offset = "0x2974800", VA = "0x182975800", Slot = "16")]
		public void ENIJEBFJHBA(MBPNHJDPPEH<InnerType> BKLMLPFOMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2975BB0", Offset = "0x2974BB0", VA = "0x182975BB0", Slot = "17")]
		public virtual void NJJHHEGPENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType HOEPDNCNJAF();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void PMGGMGPMOFM(ProtobufType AGOKOJHDPLC);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void HAECMPFIEED(byte[] CDDCFKPMPCC);
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
			[Cpp2IlInjected.Address(RVA = "0x85E9A0", Offset = "0x85D9A0", VA = "0x18085E9A0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x912800", Offset = "0x911800", VA = "0x180912800", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85E990", Offset = "0x85D990", VA = "0x18085E990", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1092750", Offset = "0x1091750", VA = "0x181092750", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBDEA00", Offset = "0xBDDA00", VA = "0x180BDEA00")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x272C6A0", Offset = "0x272B6A0", VA = "0x18272C6A0")]
		public SerializedMutableOverridableBase(bool AANDEMIALKC, InnerType CKDFGEALFAK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ECFEPLKIGAO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72DB1C0", Offset = "0x72DA1C0", VA = "0x1872DB1C0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72DB150", Offset = "0x72DA150", VA = "0x1872DB150")]
		public MutableOverridableObscuredInt(bool AANDEMIALKC, ObscuredInt CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72DB080", Offset = "0x72DA080", VA = "0x1872DB080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72DAE00", Offset = "0x72D9E00", VA = "0x1872DAE00", Slot = "20")]
		public override void HAECMPFIEED(byte[] CDDCFKPMPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72DAFB0", Offset = "0x72D9FB0", VA = "0x1872DAFB0", Slot = "19")]
		public override void PMGGMGPMOFM(ECFEPLKIGAO AGOKOJHDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72DAEB0", Offset = "0x72D9EB0", VA = "0x1872DAEB0", Slot = "18")]
		public override ECFEPLKIGAO HOEPDNCNJAF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, NBNEPKAENNL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72DAD30", Offset = "0x72D9D30", VA = "0x1872DAD30")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72DAD90", Offset = "0x72D9D90", VA = "0x1872DAD90")]
		public MutableOverridableObscuredFloat(bool AANDEMIALKC, ObscuredFloat CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72DAC60", Offset = "0x72D9C60", VA = "0x1872DAC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72DA9C0", Offset = "0x72D99C0", VA = "0x1872DA9C0", Slot = "20")]
		public override void HAECMPFIEED(byte[] CDDCFKPMPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72DAB80", Offset = "0x72D9B80", VA = "0x1872DAB80", Slot = "19")]
		public override void PMGGMGPMOFM(NBNEPKAENNL AGOKOJHDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72DAA70", Offset = "0x72D9A70", VA = "0x1872DAA70", Slot = "18")]
		public override NBNEPKAENNL HOEPDNCNJAF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GHLBAPIONFL>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72D9CB0", Offset = "0x72D8CB0", VA = "0x1872D9CB0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72DA950", Offset = "0x72D9950", VA = "0x1872DA950")]
		public MutableOverridableObscuredBool(bool AANDEMIALKC, ObscuredBool CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72DA880", Offset = "0x72D9880", VA = "0x1872DA880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72DA5A0", Offset = "0x72D95A0", VA = "0x1872DA5A0", Slot = "20")]
		public override void HAECMPFIEED(byte[] CDDCFKPMPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72DA7A0", Offset = "0x72D97A0", VA = "0x1872DA7A0", Slot = "19")]
		public override void PMGGMGPMOFM(GHLBAPIONFL AGOKOJHDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72DA650", Offset = "0x72D9650", VA = "0x1872DA650", Slot = "18")]
		public override GHLBAPIONFL HOEPDNCNJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72DA750", Offset = "0x72D9750", VA = "0x1872DA750", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, BEBEGGIHPFC<ObscuredBool>, PDJBJIIDIAI<ObscuredBool>, MBPNHJDPPEH<ObscuredBool>, OCLGENBLEGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB86BE0", VA = "0x180B87BE0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB8A670", Offset = "0xB89670", VA = "0x180B8A670", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72D9CB0", Offset = "0x72D8CB0", VA = "0x1872D9CB0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72D9C30", Offset = "0x72D8C30", VA = "0x1872D9C30")]
		public void CKPDLHEMEGA(MutableOverridableDefaultableObscuredBool BKLMLPFOMCO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ECFEPLKIGAO> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4AAB1C0", Offset = "0x4AAA1C0", VA = "0x184AAB1C0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4AAB2A0", Offset = "0x4AAA2A0", VA = "0x184AAB2A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xC025E0", Offset = "0xC015E0", VA = "0x180C025E0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB190", Offset = "0x4AAA190", VA = "0x184AAB190")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2A972C0", Offset = "0x2A962C0", VA = "0x182A972C0")]
		public SerializedMutableOverridableObscuredEnum(bool AANDEMIALKC, TObsEnum CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4AAAF40", Offset = "0x4AA9F40", VA = "0x184AAAF40", Slot = "18")]
		public sealed override ECFEPLKIGAO HOEPDNCNJAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB070", Offset = "0x4AAA070", VA = "0x184AAB070", Slot = "19")]
		public sealed override void PMGGMGPMOFM(ECFEPLKIGAO AGOKOJHDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4AAAE90", Offset = "0x4AA9E90", VA = "0x184AAAE90", Slot = "20")]
		public sealed override void HAECMPFIEED(byte[] CDDCFKPMPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB010", Offset = "0x4AAA010", VA = "0x184AAB010", Slot = "17")]
		public sealed override void NJJHHEGPENJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, HBNLJCBPNIP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x72DA4D0", Offset = "0x72D94D0", VA = "0x1872DA4D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72DA510", Offset = "0x72D9510", VA = "0x1872DA510", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72DA3E0", Offset = "0x72D93E0", VA = "0x1872DA3E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72DA470", Offset = "0x72D9470", VA = "0x1872DA470")]
		public MutableOverridableListObscuredString(bool AANDEMIALKC, List<ObscuredString> CKDFGEALFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x72DA340", Offset = "0x72D9340", VA = "0x1872DA340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72D9FB0", Offset = "0x72D8FB0", VA = "0x1872D9FB0", Slot = "17")]
		public override void NJJHHEGPENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72D9D20", Offset = "0x72D8D20", VA = "0x1872D9D20", Slot = "20")]
		public override void HAECMPFIEED(byte[] CDDCFKPMPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72DA020", Offset = "0x72D9020", VA = "0x1872DA020", Slot = "19")]
		public override void PMGGMGPMOFM(HBNLJCBPNIP AGOKOJHDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72D9DD0", Offset = "0x72D8DD0", VA = "0x1872D9DD0", Slot = "18")]
		public override HBNLJCBPNIP HOEPDNCNJAF()
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
