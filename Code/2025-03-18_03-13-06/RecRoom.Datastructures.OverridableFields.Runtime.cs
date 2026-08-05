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
public interface JAKMFMHMCOE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IGPIPFGMOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object KFAHHFHCLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KHHMOIKCEBO<T> : JAKMFMHMCOE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MNLJEDPIAIM<T> : KHHMOIKCEBO<T>, JAKMFMHMCOE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool IGPIPFGMOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T CADNOMLIGCM
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
public interface BMHMIAJMFJL<T> : MNLJEDPIAIM<T>, KHHMOIKCEBO<T>, JAKMFMHMCOE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JEKMHLJPJIH
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
	public struct OverridableInt : KHHMOIKCEBO<int>, JAKMFMHMCOE
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
			[Cpp2IlInjected.Address(RVA = "0xDEE980", Offset = "0xDEDB80", VA = "0x180DEE980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x75BED80", Offset = "0x75BDF80", VA = "0x1875BED80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75BECE0", Offset = "0x75BDEE0", VA = "0x1875BECE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : KHHMOIKCEBO<string>, JAKMFMHMCOE
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
			[Cpp2IlInjected.Address(RVA = "0xDEE980", Offset = "0xDEDB80", VA = "0x180DEE980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFC0", Offset = "0xC8D1C0", VA = "0x180C8DFC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFC0", Offset = "0xC8D1C0", VA = "0x180C8DFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75BEDD0", Offset = "0x75BDFD0", VA = "0x1875BEDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : MNLJEDPIAIM<InnerType>, KHHMOIKCEBO<InnerType>, JAKMFMHMCOE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool IGPIPFGMOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object KFAHHFHCLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x279B510", Offset = "0x279A710", VA = "0x18279B510", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E109D0", Offset = "0x4E0FBD0", VA = "0x184E109D0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E10A00", Offset = "0x4E0FC00", VA = "0x184E10A00")]
		public MutableOverridableBase(bool IPFHLECCEII, [NotNull] InnerType OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E10490", Offset = "0x4E0F690", VA = "0x184E10490", Slot = "15")]
		public void DLLFODJBFPA(KHHMOIKCEBO<InnerType> ABBANNGAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E10690", Offset = "0x4E0F890", VA = "0x184E10690", Slot = "16")]
		public void ILGAGJANMHO(KHHMOIKCEBO<InnerType> LDKNLBHIGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E101B0", Offset = "0x4E0F3B0", VA = "0x184E101B0", Slot = "17")]
		public virtual void DICECPNPBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LMIOJEAELCO();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JFMOJFGFONP(ProtobufType ALDBPIGGABO);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MHINAABIHCG(byte[] BGHEAFIJCIN);
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
			[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCD70C0", Offset = "0xCD62C0", VA = "0x180CD70C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40A7EB0", Offset = "0x40A70B0", VA = "0x1840A7EB0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4699EC0", Offset = "0x46990C0", VA = "0x184699EC0")]
		public SerializedMutableOverridableBase(bool IPFHLECCEII, InnerType OMFJNFBDJCA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, AKPFNHMNKOI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC10", Offset = "0x75BDE10", VA = "0x1875BEC10")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC70", Offset = "0x75BDE70", VA = "0x1875BEC70")]
		public MutableOverridableObscuredInt(bool IPFHLECCEII, ObscuredInt OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x75BEB40", Offset = "0x75BDD40", VA = "0x1875BEB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75BEA70", Offset = "0x75BDC70", VA = "0x1875BEA70", Slot = "20")]
		public override void MHINAABIHCG(byte[] BGHEAFIJCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75BE8E0", Offset = "0x75BDAE0", VA = "0x1875BE8E0", Slot = "19")]
		public override void JFMOJFGFONP(AKPFNHMNKOI ALDBPIGGABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75BE990", Offset = "0x75BDB90", VA = "0x1875BE990", Slot = "18")]
		public override AKPFNHMNKOI LMIOJEAELCO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MBDGEBGIALA>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75BE810", Offset = "0x75BDA10", VA = "0x1875BE810")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75BE870", Offset = "0x75BDA70", VA = "0x1875BE870")]
		public MutableOverridableObscuredFloat(bool IPFHLECCEII, ObscuredFloat OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75BE740", Offset = "0x75BD940", VA = "0x1875BE740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75BE670", Offset = "0x75BD870", VA = "0x1875BE670", Slot = "20")]
		public override void MHINAABIHCG(byte[] BGHEAFIJCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75BE4C0", Offset = "0x75BD6C0", VA = "0x1875BE4C0", Slot = "19")]
		public override void JFMOJFGFONP(MBDGEBGIALA ALDBPIGGABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75BE580", Offset = "0x75BD780", VA = "0x1875BE580", Slot = "18")]
		public override MBDGEBGIALA LMIOJEAELCO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PIAHCMKMHFK>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75BD6F0", Offset = "0x75BC8F0", VA = "0x1875BD6F0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75BE450", Offset = "0x75BD650", VA = "0x1875BE450")]
		public MutableOverridableObscuredBool(bool IPFHLECCEII, ObscuredBool OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75BE380", Offset = "0x75BD580", VA = "0x1875BE380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75BE220", Offset = "0x75BD420", VA = "0x1875BE220", Slot = "20")]
		public override void MHINAABIHCG(byte[] BGHEAFIJCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75BE070", Offset = "0x75BD270", VA = "0x1875BE070", Slot = "19")]
		public override void JFMOJFGFONP(PIAHCMKMHFK ALDBPIGGABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75BE130", Offset = "0x75BD330", VA = "0x1875BE130", Slot = "18")]
		public override PIAHCMKMHFK LMIOJEAELCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75BE2F0", Offset = "0x75BD4F0", VA = "0x1875BE2F0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, BMHMIAJMFJL<ObscuredBool>, MNLJEDPIAIM<ObscuredBool>, KHHMOIKCEBO<ObscuredBool>, JAKMFMHMCOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x964F50", Offset = "0x964150", VA = "0x180964F50", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75BD6F0", Offset = "0x75BC8F0", VA = "0x1875BD6F0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75BD670", Offset = "0x75BC870", VA = "0x1875BD670")]
		public void DLLFODJBFPA(MutableOverridableDefaultableObscuredBool LDKNLBHIGFL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, AKPFNHMNKOI> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5334980", Offset = "0x5333B80", VA = "0x185334980", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5334AF0", Offset = "0x5333CF0", VA = "0x185334AF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4655850", Offset = "0x4654A50", VA = "0x184655850")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5334940", Offset = "0x5333B40", VA = "0x185334940")]
		public SerializedMutableOverridableObscuredEnum(bool IPFHLECCEII, TObsEnum OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5334770", Offset = "0x5333970", VA = "0x185334770", Slot = "18")]
		public sealed override AKPFNHMNKOI LMIOJEAELCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5334670", Offset = "0x5333870", VA = "0x185334670", Slot = "19")]
		public sealed override void JFMOJFGFONP(AKPFNHMNKOI ALDBPIGGABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5334860", Offset = "0x5333A60", VA = "0x185334860", Slot = "20")]
		public sealed override void MHINAABIHCG(byte[] BGHEAFIJCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x53345F0", Offset = "0x53337F0", VA = "0x1853345F0", Slot = "17")]
		public sealed override void DICECPNPBPH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PPAPOMFIAFP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x75BDFA0", Offset = "0x75BD1A0", VA = "0x1875BDFA0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x75BDFE0", Offset = "0x75BD1E0", VA = "0x1875BDFE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75BDF00", Offset = "0x75BD100", VA = "0x1875BDF00")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75BDEA0", Offset = "0x75BD0A0", VA = "0x1875BDEA0")]
		public MutableOverridableListObscuredString(bool IPFHLECCEII, List<ObscuredString> OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75BDE00", Offset = "0x75BD000", VA = "0x1875BDE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x75BD760", Offset = "0x75BC960", VA = "0x1875BD760", Slot = "17")]
		public override void DICECPNPBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75BDD30", Offset = "0x75BCF30", VA = "0x1875BDD30", Slot = "20")]
		public override void MHINAABIHCG(byte[] BGHEAFIJCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75BD7F0", Offset = "0x75BC9F0", VA = "0x1875BD7F0", Slot = "19")]
		public override void JFMOJFGFONP(PPAPOMFIAFP ALDBPIGGABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75BDB50", Offset = "0x75BCD50", VA = "0x1875BDB50", Slot = "18")]
		public override PPAPOMFIAFP LMIOJEAELCO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : KHHMOIKCEBO<Vector3>, JAKMFMHMCOE
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
			[Cpp2IlInjected.Address(RVA = "0xDEE980", Offset = "0xDEDB80", VA = "0x180DEE980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75BEF00", Offset = "0x75BE100", VA = "0x1875BEF00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4B1CCE0", Offset = "0x4B1BEE0", VA = "0x184B1CCE0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F1C7E0", Offset = "0x4F1B9E0", VA = "0x184F1C7E0")]
		public OverridableVector3(Vector3 OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x56066E0", Offset = "0x56058E0", VA = "0x1856066E0")]
		public OverridableVector3(bool IPFHLECCEII, Vector3 OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75BEE60", Offset = "0x75BE060", VA = "0x1875BEE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75BEE40", Offset = "0x75BE040", VA = "0x1875BEE40")]
		public static OverridableVector3 AJAOLMPMCKD(Vector3 HBMPJOCKNNL)
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
