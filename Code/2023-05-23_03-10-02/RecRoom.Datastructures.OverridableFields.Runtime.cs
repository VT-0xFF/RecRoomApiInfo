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
public interface OAFEIMNLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KKBHMEAHEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object OOGPOFPCCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HILCBNNOOPE<T> : OAFEIMNLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHFOABEHLND<T> : global::HILCBNNOOPE<T>, OAFEIMNLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool KKBHMEAHEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DEMEBAENMIP
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
public interface EPFMHIKIOBD<T> : global::AHFOABEHLND<T>, global::HILCBNNOOPE<T>, OAFEIMNLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LLCMAGJOCEJ
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
	public struct OverridableVector3 : global::HILCBNNOOPE<Vector3>, OAFEIMNLGGJ
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
			[Cpp2IlInjected.Address(RVA = "0x16E8190", Offset = "0x16E7590", VA = "0x1816E8190", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x16E8300", Offset = "0x16E7700", VA = "0x1816E8300", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x16E8350", Offset = "0x16E7750", VA = "0x1816E8350", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16E82E0", Offset = "0x16E76E0", VA = "0x1816E82E0")]
		public OverridableVector3(Vector3 EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16E8240", Offset = "0x16E7640", VA = "0x1816E8240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x16E8210", Offset = "0x16E7610", VA = "0x1816E8210")]
		public static OverridableVector3 ILINJACDGKH(Vector3 NLNMFNDNKJH)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : global::HILCBNNOOPE<int>, OAFEIMNLGGJ
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
			[Cpp2IlInjected.Address(RVA = "0x16E8190", Offset = "0x16E7590", VA = "0x1816E8190", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x16E8140", Offset = "0x16E7540", VA = "0x1816E8140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC8AD00", Offset = "0xC8A100", VA = "0x180C8AD00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x16E80A0", Offset = "0x16E74A0", VA = "0x1816E80A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : global::HILCBNNOOPE<string>, OAFEIMNLGGJ
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
			[Cpp2IlInjected.Address(RVA = "0x16E8190", Offset = "0x16E7590", VA = "0x1816E8190", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE4D070", Offset = "0xE4C470", VA = "0x180E4D070", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE4D070", Offset = "0xE4C470", VA = "0x180E4D070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16E81A0", Offset = "0x16E75A0", VA = "0x1816E81A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::AHFOABEHLND<InnerType>, global::HILCBNNOOPE<InnerType>, OAFEIMNLGGJ where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool KKBHMEAHEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType DEMEBAENMIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object OOGPOFPCCBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2CCC4A0", Offset = "0x2CCB8A0", VA = "0x182CCC4A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3357410", Offset = "0x3356810", VA = "0x183357410")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x33574D0", Offset = "0x33568D0", VA = "0x1833574D0")]
		public MutableOverridableBase(bool DIEBPEOGLIN, [NotNull] InnerType EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3357240", Offset = "0x3356640", VA = "0x183357240", Slot = "15")]
		public void OPBCGGOGLLC(global::HILCBNNOOPE<InnerType> HCFOCMDADMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3356AC0", Offset = "0x3355EC0", VA = "0x183356AC0", Slot = "16")]
		public void EADENLHKLFK(global::HILCBNNOOPE<InnerType> CCJMBGJFGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3356ED0", Offset = "0x33562D0", VA = "0x183356ED0", Slot = "17")]
		public virtual void LLMEAOAJOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType EPDEONOEJGG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OPFOIPFOHJG(ProtobufType HECPAAHBMDA);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DOBHKINCIEG(byte[] ABJKGJFPLMI);
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
			[Cpp2IlInjected.Address(RVA = "0xC73230", Offset = "0xC72630", VA = "0x180C73230", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x85A220", Offset = "0x859620", VA = "0x18085A220", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x87B360", Offset = "0x87A760", VA = "0x18087B360", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1ABBC80", Offset = "0x1ABB080", VA = "0x181ABBC80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1A92430", Offset = "0x1A91830", VA = "0x181A92430")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x42772A0", Offset = "0x42766A0", VA = "0x1842772A0")]
		public SerializedMutableOverridableBase(bool DIEBPEOGLIN, InnerType EOEKGHMNIDN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PENKCDNOJBC>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x16E8040", Offset = "0x16E7440", VA = "0x1816E8040")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x16E7FD0", Offset = "0x16E73D0", VA = "0x1816E7FD0")]
		public MutableOverridableObscuredInt(bool DIEBPEOGLIN, ObscuredInt EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x16E7F00", Offset = "0x16E7300", VA = "0x1816E7F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x16E7C80", Offset = "0x16E7080", VA = "0x1816E7C80", Slot = "20")]
		public override void DOBHKINCIEG(byte[] ABJKGJFPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x16E7E30", Offset = "0x16E7230", VA = "0x1816E7E30", Slot = "19")]
		public override void OPFOIPFOHJG(PENKCDNOJBC HECPAAHBMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x16E7D30", Offset = "0x16E7130", VA = "0x1816E7D30", Slot = "18")]
		public override PENKCDNOJBC EPDEONOEJGG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, ANDLKOAAFAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x16E7BB0", Offset = "0x16E6FB0", VA = "0x1816E7BB0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x16E7C10", Offset = "0x16E7010", VA = "0x1816E7C10")]
		public MutableOverridableObscuredFloat(bool DIEBPEOGLIN, ObscuredFloat EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x16E7AE0", Offset = "0x16E6EE0", VA = "0x1816E7AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x16E7840", Offset = "0x16E6C40", VA = "0x1816E7840", Slot = "20")]
		public override void DOBHKINCIEG(byte[] ABJKGJFPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x16E7A00", Offset = "0x16E6E00", VA = "0x1816E7A00", Slot = "19")]
		public override void OPFOIPFOHJG(ANDLKOAAFAJ HECPAAHBMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x16E78F0", Offset = "0x16E6CF0", VA = "0x1816E78F0", Slot = "18")]
		public override ANDLKOAAFAJ EPDEONOEJGG()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KEABBPEHNCD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x16E6B40", Offset = "0x16E5F40", VA = "0x1816E6B40")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16E77D0", Offset = "0x16E6BD0", VA = "0x1816E77D0")]
		public MutableOverridableObscuredBool(bool DIEBPEOGLIN, ObscuredBool EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x16E7700", Offset = "0x16E6B00", VA = "0x1816E7700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x16E7430", Offset = "0x16E6830", VA = "0x1816E7430", Slot = "20")]
		public override void DOBHKINCIEG(byte[] ABJKGJFPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x16E75E0", Offset = "0x16E69E0", VA = "0x1816E75E0", Slot = "19")]
		public override void OPFOIPFOHJG(KEABBPEHNCD HECPAAHBMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x16E74E0", Offset = "0x16E68E0", VA = "0x1816E74E0", Slot = "18")]
		public override KEABBPEHNCD EPDEONOEJGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x16E76C0", Offset = "0x16E6AC0", VA = "0x1816E76C0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::EPFMHIKIOBD<ObscuredBool>, global::AHFOABEHLND<ObscuredBool>, global::HILCBNNOOPE<ObscuredBool>, OAFEIMNLGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x90E440", Offset = "0x90D840", VA = "0x18090E440", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9A1670", Offset = "0x9A0A70", VA = "0x1809A1670", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x16E6B40", Offset = "0x16E5F40", VA = "0x1816E6B40")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x16E6AC0", Offset = "0x16E5EC0", VA = "0x1816E6AC0")]
		public void OPBCGGOGLLC(MutableOverridableDefaultableObscuredBool CCJMBGJFGLH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PENKCDNOJBC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4277780", Offset = "0x4276B80", VA = "0x184277780", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4277860", Offset = "0x4276C60", VA = "0x184277860", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3306E00", Offset = "0x3306200", VA = "0x183306E00")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4277750", Offset = "0x4276B50", VA = "0x184277750")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4277720", Offset = "0x4276B20", VA = "0x184277720")]
		public SerializedMutableOverridableObscuredEnum(bool DIEBPEOGLIN, TObsEnum EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42774D0", Offset = "0x42768D0", VA = "0x1842774D0", Slot = "18")]
		public sealed override PENKCDNOJBC EPDEONOEJGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4277600", Offset = "0x4276A00", VA = "0x184277600", Slot = "19")]
		public sealed override void OPFOIPFOHJG(PENKCDNOJBC HECPAAHBMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4277420", Offset = "0x4276820", VA = "0x184277420", Slot = "20")]
		public sealed override void DOBHKINCIEG(byte[] ABJKGJFPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42775A0", Offset = "0x42769A0", VA = "0x1842775A0", Slot = "17")]
		public sealed override void LLMEAOAJOJJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, BCBKHCIEEKL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x16E7360", Offset = "0x16E6760", VA = "0x1816E7360", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x16E73A0", Offset = "0x16E67A0", VA = "0x1816E73A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x16E7270", Offset = "0x16E6670", VA = "0x1816E7270")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x16E7300", Offset = "0x16E6700", VA = "0x1816E7300")]
		public MutableOverridableListObscuredString(bool DIEBPEOGLIN, List<ObscuredString> EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x16E71D0", Offset = "0x16E65D0", VA = "0x1816E71D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16E6E40", Offset = "0x16E6240", VA = "0x1816E6E40", Slot = "17")]
		public override void LLMEAOAJOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x16E6BB0", Offset = "0x16E5FB0", VA = "0x1816E6BB0", Slot = "20")]
		public override void DOBHKINCIEG(byte[] ABJKGJFPLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x16E6EB0", Offset = "0x16E62B0", VA = "0x1816E6EB0", Slot = "19")]
		public override void OPFOIPFOHJG(BCBKHCIEEKL HECPAAHBMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x16E6C60", Offset = "0x16E6060", VA = "0x1816E6C60", Slot = "18")]
		public override BCBKHCIEEKL EPDEONOEJGG()
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
