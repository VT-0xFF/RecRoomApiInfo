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
public interface CEOKEDPDGCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AEOFGIPEIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object EFAKDIIPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBJODGPOKIB<T> : CEOKEDPDGCF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CALIOJMEAJH<T> : global::CBJODGPOKIB<T>, CEOKEDPDGCF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool AEOFGIPEIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T PPNOOBBHMAN
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
public interface KJFBOLKCEMP<T> : global::CALIOJMEAJH<T>, global::CBJODGPOKIB<T>, CEOKEDPDGCF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FIFMALAMFJC
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
	public struct OverridableInt : global::CBJODGPOKIB<int>, CEOKEDPDGCF
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
			[Cpp2IlInjected.Address(RVA = "0x8A8920", Offset = "0x8A7120", VA = "0x1808A8920", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x65C8D50", Offset = "0x65C7550", VA = "0x1865C8D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65C8CB0", Offset = "0x65C74B0", VA = "0x1865C8CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::CBJODGPOKIB<string>, CEOKEDPDGCF
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
			[Cpp2IlInjected.Address(RVA = "0x8A8920", Offset = "0x8A7120", VA = "0x1808A8920", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72B840", Offset = "0x72A040", VA = "0x18072B840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72B840", Offset = "0x72A040", VA = "0x18072B840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65C8DA0", Offset = "0x65C75A0", VA = "0x1865C8DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::CALIOJMEAJH<InnerType>, global::CBJODGPOKIB<InnerType>, CEOKEDPDGCF where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool AEOFGIPEIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType PPNOOBBHMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object EFAKDIIPEBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2DCD810", Offset = "0x2DCC010", VA = "0x182DCD810", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E30320", Offset = "0x2E2EB20", VA = "0x182E30320")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2E303E0", Offset = "0x2E2EBE0", VA = "0x182E303E0")]
		public MutableOverridableBase(bool BFJNNEJMBFD, [NotNull] InnerType NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FA60", Offset = "0x2E2E260", VA = "0x182E2FA60", Slot = "15")]
		public void AILOJFBNBPB(global::CBJODGPOKIB<InnerType> NGLBFFFIHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FC20", Offset = "0x2E2E420", VA = "0x182E2FC20", Slot = "16")]
		public void LBMJLEFFBAH(global::CBJODGPOKIB<InnerType> HAKPJJGEGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2E300B0", Offset = "0x2E2E8B0", VA = "0x182E300B0", Slot = "17")]
		public virtual void NDKMADGHFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GJIPNKGAPFN();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void PIFFJIGJOLL(ProtobufType MGMNAOMLOGC);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void NIENCMONPAE(byte[] KDLHKHMBJMD);
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
			[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D9270", Offset = "0x6D7A70", VA = "0x1806D9270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x16CD960", Offset = "0x16CC160", VA = "0x1816CD960", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1611780", Offset = "0x160FF80", VA = "0x181611780")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2C71E70", Offset = "0x2C70670", VA = "0x182C71E70")]
		public SerializedMutableOverridableBase(bool BFJNNEJMBFD, InnerType NPHADDCNBHE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, CCNLOBFAMFF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x65C8C50", Offset = "0x65C7450", VA = "0x1865C8C50")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x65C8BE0", Offset = "0x65C73E0", VA = "0x1865C8BE0")]
		public MutableOverridableObscuredInt(bool BFJNNEJMBFD, ObscuredInt NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x65C8B10", Offset = "0x65C7310", VA = "0x1865C8B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x65C8950", Offset = "0x65C7150", VA = "0x1865C8950", Slot = "20")]
		public override void NIENCMONPAE(byte[] KDLHKHMBJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x65C8A50", Offset = "0x65C7250", VA = "0x1865C8A50", Slot = "19")]
		public override void PIFFJIGJOLL(CCNLOBFAMFF MGMNAOMLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65C8870", Offset = "0x65C7070", VA = "0x1865C8870", Slot = "18")]
		public override CCNLOBFAMFF GJIPNKGAPFN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, ENLLJJGGOBI>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x65C87A0", Offset = "0x65C6FA0", VA = "0x1865C87A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x65C8800", Offset = "0x65C7000", VA = "0x1865C8800")]
		public MutableOverridableObscuredFloat(bool BFJNNEJMBFD, ObscuredFloat NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x65C86D0", Offset = "0x65C6ED0", VA = "0x1865C86D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x65C8500", Offset = "0x65C6D00", VA = "0x1865C8500", Slot = "20")]
		public override void NIENCMONPAE(byte[] KDLHKHMBJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x65C8600", Offset = "0x65C6E00", VA = "0x1865C8600", Slot = "19")]
		public override void PIFFJIGJOLL(ENLLJJGGOBI MGMNAOMLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x65C8410", Offset = "0x65C6C10", VA = "0x1865C8410", Slot = "18")]
		public override ENLLJJGGOBI GJIPNKGAPFN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GBECHKGEDKF>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x65C76D0", Offset = "0x65C5ED0", VA = "0x1865C76D0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x65C83A0", Offset = "0x65C6BA0", VA = "0x1865C83A0")]
		public MutableOverridableObscuredBool(bool BFJNNEJMBFD, ObscuredBool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x65C82D0", Offset = "0x65C6AD0", VA = "0x1865C82D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x65C80D0", Offset = "0x65C68D0", VA = "0x1865C80D0", Slot = "20")]
		public override void NIENCMONPAE(byte[] KDLHKHMBJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65C8210", Offset = "0x65C6A10", VA = "0x1865C8210", Slot = "19")]
		public override void PIFFJIGJOLL(GBECHKGEDKF MGMNAOMLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65C7FF0", Offset = "0x65C67F0", VA = "0x1865C7FF0", Slot = "18")]
		public override GBECHKGEDKF GJIPNKGAPFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65C81D0", Offset = "0x65C69D0", VA = "0x1865C81D0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::KJFBOLKCEMP<ObscuredBool>, global::CALIOJMEAJH<ObscuredBool>, global::CBJODGPOKIB<ObscuredBool>, CEOKEDPDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F03D0", Offset = "0x6EEBD0", VA = "0x1806F03D0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801310", VA = "0x180802B10", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x65C76D0", Offset = "0x65C5ED0", VA = "0x1865C76D0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x65C7650", Offset = "0x65C5E50", VA = "0x1865C7650")]
		public void AILOJFBNBPB(MutableOverridableDefaultableObscuredBool HAKPJJGEGOM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, CCNLOBFAMFF> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4355360", Offset = "0x4353B60", VA = "0x184355360", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4355440", Offset = "0x4353C40", VA = "0x184355440", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x265C890", Offset = "0x265B090", VA = "0x18265C890")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4355330", Offset = "0x4353B30", VA = "0x184355330")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2C6FB50", Offset = "0x2C6E350", VA = "0x182C6FB50")]
		public SerializedMutableOverridableObscuredEnum(bool BFJNNEJMBFD, TObsEnum NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4355010", Offset = "0x4353810", VA = "0x184355010", Slot = "18")]
		public sealed override CCNLOBFAMFF GJIPNKGAPFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4355220", Offset = "0x4353A20", VA = "0x184355220", Slot = "19")]
		public sealed override void PIFFJIGJOLL(CCNLOBFAMFF MGMNAOMLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4355120", Offset = "0x4353920", VA = "0x184355120", Slot = "20")]
		public sealed override void NIENCMONPAE(byte[] KDLHKHMBJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x43550C0", Offset = "0x43538C0", VA = "0x1843550C0", Slot = "17")]
		public sealed override void NDKMADGHFAP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PALIHKHFHGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x65C7F20", Offset = "0x65C6720", VA = "0x1865C7F20", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x65C7F60", Offset = "0x65C6760", VA = "0x1865C7F60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65C7E30", Offset = "0x65C6630", VA = "0x1865C7E30")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65C7EC0", Offset = "0x65C66C0", VA = "0x1865C7EC0")]
		public MutableOverridableListObscuredString(bool BFJNNEJMBFD, List<ObscuredString> NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65C7D90", Offset = "0x65C6590", VA = "0x1865C7D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65C7900", Offset = "0x65C6100", VA = "0x1865C7900", Slot = "17")]
		public override void NDKMADGHFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65C7970", Offset = "0x65C6170", VA = "0x1865C7970", Slot = "20")]
		public override void NIENCMONPAE(byte[] KDLHKHMBJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65C7A70", Offset = "0x65C6270", VA = "0x1865C7A70", Slot = "19")]
		public override void PIFFJIGJOLL(PALIHKHFHGJ MGMNAOMLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65C7740", Offset = "0x65C5F40", VA = "0x1865C7740", Slot = "18")]
		public override PALIHKHFHGJ GJIPNKGAPFN()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::CBJODGPOKIB<Vector3>, CEOKEDPDGCF
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
			[Cpp2IlInjected.Address(RVA = "0x8A8920", Offset = "0x8A7120", VA = "0x1808A8920", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65C8EF0", Offset = "0x65C76F0", VA = "0x1865C8EF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1C5D860", Offset = "0x1C5C060", VA = "0x181C5D860", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x65C8ED0", Offset = "0x65C76D0", VA = "0x1865C8ED0")]
		public OverridableVector3(Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x65C8E30", Offset = "0x65C7630", VA = "0x1865C8E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x65C8E10", Offset = "0x65C7610", VA = "0x1865C8E10")]
		public static OverridableVector3 AGJOPELLCGM(Vector3 EAPKDOJGNBJ)
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
