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
public interface DCNHFDCKKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CHFFCOFECHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object ECCMPLBFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NADHNAAPMOF<T> : DCNHFDCKKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PKKINNENDEC<T> : global::NADHNAAPMOF<T>, DCNHFDCKKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CHFFCOFECHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T LKDHJKNGKHD
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
public interface NEDFGPMADJN<T> : global::PKKINNENDEC<T>, global::NADHNAAPMOF<T>, DCNHFDCKKPN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LPDPKOLNKGM
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
	public struct OverridableInt : global::NADHNAAPMOF<int>, DCNHFDCKKPN
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
			[Cpp2IlInjected.Address(RVA = "0x8CCAD0", Offset = "0x8CBCD0", VA = "0x1808CCAD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x67DE2A0", Offset = "0x67DD4A0", VA = "0x1867DE2A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x18C79E0", Offset = "0x18C6BE0", VA = "0x1818C79E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67DE200", Offset = "0x67DD400", VA = "0x1867DE200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::NADHNAAPMOF<string>, DCNHFDCKKPN
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
			[Cpp2IlInjected.Address(RVA = "0x8CCAD0", Offset = "0x8CBCD0", VA = "0x1808CCAD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF900", Offset = "0x7AEB00", VA = "0x1807AF900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF900", Offset = "0x7AEB00", VA = "0x1807AF900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x67DE2F0", Offset = "0x67DD4F0", VA = "0x1867DE2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::PKKINNENDEC<InnerType>, global::NADHNAAPMOF<InnerType>, DCNHFDCKKPN where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool CHFFCOFECHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType LKDHJKNGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object ECCMPLBFDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2470E90", Offset = "0x2470090", VA = "0x182470E90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x24A8D30", Offset = "0x24A7F30", VA = "0x1824A8D30")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x24A8DF0", Offset = "0x24A7FF0", VA = "0x1824A8DF0")]
		public MutableOverridableBase(bool FMMJFLMIBAO, [NotNull] InnerType IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x24A8730", Offset = "0x24A7930", VA = "0x1824A8730", Slot = "15")]
		public void JGMLMOAPKAE(global::NADHNAAPMOF<InnerType> LNCLFEFOOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24A8520", Offset = "0x24A7720", VA = "0x1824A8520", Slot = "16")]
		public void EKNKDADOBNE(global::NADHNAAPMOF<InnerType> HNPEBINPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24A8B80", Offset = "0x24A7D80", VA = "0x1824A8B80", Slot = "17")]
		public virtual void PAKIMOKGMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType EIEJLKMEIMJ();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HMFJDIIHHIE(ProtobufType IHAKFKBPMEN);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void NMGPCGADIAG(byte[] KGOMFEKLMFG);
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
			[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x707EE0", Offset = "0x7070E0", VA = "0x180707EE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x766BB0", Offset = "0x765DB0", VA = "0x180766BB0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891230", VA = "0x180892030")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D460", Offset = "0x1B4C660", VA = "0x181B4D460")]
		public SerializedMutableOverridableBase(bool FMMJFLMIBAO, InnerType IPMIIEAGJKC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, OOHLLDHBLFM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67DE1A0", Offset = "0x67DD3A0", VA = "0x1867DE1A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67DE130", Offset = "0x67DD330", VA = "0x1867DE130")]
		public MutableOverridableObscuredInt(bool FMMJFLMIBAO, ObscuredInt IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67DE060", Offset = "0x67DD260", VA = "0x1867DE060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67DDF60", Offset = "0x67DD160", VA = "0x1867DDF60", Slot = "20")]
		public override void NMGPCGADIAG(byte[] KGOMFEKLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67DDEA0", Offset = "0x67DD0A0", VA = "0x1867DDEA0", Slot = "19")]
		public override void HMFJDIIHHIE(OOHLLDHBLFM IHAKFKBPMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67DDDC0", Offset = "0x67DCFC0", VA = "0x1867DDDC0", Slot = "18")]
		public override OOHLLDHBLFM EIEJLKMEIMJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, CPFEFAPDIOG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67DDCF0", Offset = "0x67DCEF0", VA = "0x1867DDCF0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67DDD50", Offset = "0x67DCF50", VA = "0x1867DDD50")]
		public MutableOverridableObscuredFloat(bool FMMJFLMIBAO, ObscuredFloat IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67DDC20", Offset = "0x67DCE20", VA = "0x1867DDC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67DDB20", Offset = "0x67DCD20", VA = "0x1867DDB20", Slot = "20")]
		public override void NMGPCGADIAG(byte[] KGOMFEKLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67DDA50", Offset = "0x67DCC50", VA = "0x1867DDA50", Slot = "19")]
		public override void HMFJDIIHHIE(CPFEFAPDIOG IHAKFKBPMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67DD960", Offset = "0x67DCB60", VA = "0x1867DD960", Slot = "18")]
		public override CPFEFAPDIOG EIEJLKMEIMJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, IFGGOCIIJGE>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67DCC20", Offset = "0x67DBE20", VA = "0x1867DCC20")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67DD8F0", Offset = "0x67DCAF0", VA = "0x1867DD8F0")]
		public MutableOverridableObscuredBool(bool FMMJFLMIBAO, ObscuredBool IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67DD820", Offset = "0x67DCA20", VA = "0x1867DD820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67DD6E0", Offset = "0x67DC8E0", VA = "0x1867DD6E0", Slot = "20")]
		public override void NMGPCGADIAG(byte[] KGOMFEKLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67DD620", Offset = "0x67DC820", VA = "0x1867DD620", Slot = "19")]
		public override void HMFJDIIHHIE(IFGGOCIIJGE IHAKFKBPMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67DD540", Offset = "0x67DC740", VA = "0x1867DD540", Slot = "18")]
		public override IFGGOCIIJGE EIEJLKMEIMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67DD7E0", Offset = "0x67DC9E0", VA = "0x1867DD7E0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::NEDFGPMADJN<ObscuredBool>, global::PKKINNENDEC<ObscuredBool>, global::NADHNAAPMOF<ObscuredBool>, DCNHFDCKKPN
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8297A0", Offset = "0x8289A0", VA = "0x1808297A0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x829910", Offset = "0x828B10", VA = "0x180829910", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67DCC20", Offset = "0x67DBE20", VA = "0x1867DCC20")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67DCBA0", Offset = "0x67DBDA0", VA = "0x1867DCBA0")]
		public void JGMLMOAPKAE(MutableOverridableDefaultableObscuredBool HNPEBINPOBO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, OOHLLDHBLFM> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x29DC800", Offset = "0x29DBA00", VA = "0x1829DC800", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x29DC8E0", Offset = "0x29DBAE0", VA = "0x1829DC8E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9050", Offset = "0x1BB8250", VA = "0x181BB9050")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29DC7D0", Offset = "0x29DB9D0", VA = "0x1829DC7D0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x29DC7A0", Offset = "0x29DB9A0", VA = "0x1829DC7A0")]
		public SerializedMutableOverridableObscuredEnum(bool FMMJFLMIBAO, TObsEnum IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x29DC480", Offset = "0x29DB680", VA = "0x1829DC480", Slot = "18")]
		public sealed override OOHLLDHBLFM EIEJLKMEIMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29DC530", Offset = "0x29DB730", VA = "0x1829DC530", Slot = "19")]
		public sealed override void HMFJDIIHHIE(OOHLLDHBLFM IHAKFKBPMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x29DC640", Offset = "0x29DB840", VA = "0x1829DC640", Slot = "20")]
		public sealed override void NMGPCGADIAG(byte[] KGOMFEKLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x29DC740", Offset = "0x29DB940", VA = "0x1829DC740", Slot = "17")]
		public sealed override void PAKIMOKGMBI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FBIHPHOCNAO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67DD470", Offset = "0x67DC670", VA = "0x1867DD470", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x67DD4B0", Offset = "0x67DC6B0", VA = "0x1867DD4B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67DD380", Offset = "0x67DC580", VA = "0x1867DD380")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x67DD410", Offset = "0x67DC610", VA = "0x1867DD410")]
		public MutableOverridableListObscuredString(bool FMMJFLMIBAO, List<ObscuredString> IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67DD2E0", Offset = "0x67DC4E0", VA = "0x1867DD2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67DD270", Offset = "0x67DC470", VA = "0x1867DD270", Slot = "17")]
		public override void PAKIMOKGMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67DD170", Offset = "0x67DC370", VA = "0x1867DD170", Slot = "20")]
		public override void NMGPCGADIAG(byte[] KGOMFEKLMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67DCE50", Offset = "0x67DC050", VA = "0x1867DCE50", Slot = "19")]
		public override void HMFJDIIHHIE(FBIHPHOCNAO IHAKFKBPMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67DCC90", Offset = "0x67DBE90", VA = "0x1867DCC90", Slot = "18")]
		public override FBIHPHOCNAO EIEJLKMEIMJ()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::NADHNAAPMOF<Vector3>, DCNHFDCKKPN
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
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAD0", Offset = "0x8CBCD0", VA = "0x1808CCAD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67DE440", Offset = "0x67DD640", VA = "0x1867DE440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1BFABA0", Offset = "0x1BF9DA0", VA = "0x181BFABA0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67DE420", Offset = "0x67DD620", VA = "0x1867DE420")]
		public OverridableVector3(Vector3 IPMIIEAGJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67DE380", Offset = "0x67DD580", VA = "0x1867DE380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67DE360", Offset = "0x67DD560", VA = "0x1867DE360")]
		public static OverridableVector3 GJGPFJHFLAE(Vector3 DGAGNFOEEIJ)
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
