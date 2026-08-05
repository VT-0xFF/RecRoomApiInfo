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
public interface AAMPBNIOAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PLBEBHKLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object DOHKFKHCLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HEFCBGFIADE<T> : AAMPBNIOAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FOHMOMDGFGF<T> : HEFCBGFIADE<T>, AAMPBNIOAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool PLBEBHKLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T DEDOPNLMLPL
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
public interface AOHNBHBJCBL<T> : FOHMOMDGFGF<T>, HEFCBGFIADE<T>, AAMPBNIOAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CPJEOLANDID
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
	public struct OverridableInt : HEFCBGFIADE<int>, AAMPBNIOAAP
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
			[Cpp2IlInjected.Address(RVA = "0xD77BA0", Offset = "0xD761A0", VA = "0x180D77BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x74C6410", Offset = "0x74C4A10", VA = "0x1874C6410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6370", Offset = "0x74C4970", VA = "0x1874C6370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : HEFCBGFIADE<string>, AAMPBNIOAAP
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
			[Cpp2IlInjected.Address(RVA = "0xD77BA0", Offset = "0xD761A0", VA = "0x180D77BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC3A160", Offset = "0xC38760", VA = "0x180C3A160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC3A160", Offset = "0xC38760", VA = "0x180C3A160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74C6460", Offset = "0x74C4A60", VA = "0x1874C6460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : FOHMOMDGFGF<InnerType>, HEFCBGFIADE<InnerType>, AAMPBNIOAAP where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool PLBEBHKLOEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object DOHKFKHCLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x275BFF0", Offset = "0x275A5F0", VA = "0x18275BFF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A680", Offset = "0x4E78C80", VA = "0x184E7A680")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A6B0", Offset = "0x4E78CB0", VA = "0x184E7A6B0")]
		public MutableOverridableBase(bool NHKABEKLDED, [NotNull] InnerType KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A2B0", Offset = "0x4E788B0", VA = "0x184E7A2B0", Slot = "15")]
		public void KJHFOMGAEOH(HEFCBGFIADE<InnerType> HBBIFNILMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E79E90", Offset = "0x4E78490", VA = "0x184E79E90", Slot = "16")]
		public void CFNGCKEKLEF(HEFCBGFIADE<InnerType> OKCHLIEAIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A640", Offset = "0x4E78C40", VA = "0x184E7A640", Slot = "17")]
		public virtual void KLOHADBCHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType AJHIJKHBOOK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void HDOKFBFPFNM(ProtobufType FMPCPEMKMLL);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void INPBGNOCMBE(byte[] MGHGDDFBKPJ);
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
			[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB45120", Offset = "0xB43720", VA = "0x180B45120", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC81DD0", Offset = "0xC803D0", VA = "0x180C81DD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x531CA20", Offset = "0x531B020", VA = "0x18531CA20")]
		public SerializedMutableOverridableBase(bool NHKABEKLDED, InnerType KBGCCIOIGBD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PCELLPEENHC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74C62A0", Offset = "0x74C48A0", VA = "0x1874C62A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74C6300", Offset = "0x74C4900", VA = "0x1874C6300")]
		public MutableOverridableObscuredInt(bool NHKABEKLDED, ObscuredInt KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74C61D0", Offset = "0x74C47D0", VA = "0x1874C61D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74C60F0", Offset = "0x74C46F0", VA = "0x1874C60F0", Slot = "20")]
		public override void INPBGNOCMBE(byte[] MGHGDDFBKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74C6040", Offset = "0x74C4640", VA = "0x1874C6040", Slot = "19")]
		public override void HDOKFBFPFNM(PCELLPEENHC FMPCPEMKMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74C5F60", Offset = "0x74C4560", VA = "0x1874C5F60", Slot = "18")]
		public override PCELLPEENHC AJHIJKHBOOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LMDLKPMFHFG>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74C5E90", Offset = "0x74C4490", VA = "0x1874C5E90")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74C5EF0", Offset = "0x74C44F0", VA = "0x1874C5EF0")]
		public MutableOverridableObscuredFloat(bool NHKABEKLDED, ObscuredFloat KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x74C5DC0", Offset = "0x74C43C0", VA = "0x1874C5DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74C5CE0", Offset = "0x74C42E0", VA = "0x1874C5CE0", Slot = "20")]
		public override void INPBGNOCMBE(byte[] MGHGDDFBKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74C5C20", Offset = "0x74C4220", VA = "0x1874C5C20", Slot = "19")]
		public override void HDOKFBFPFNM(LMDLKPMFHFG FMPCPEMKMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74C5B30", Offset = "0x74C4130", VA = "0x1874C5B30", Slot = "18")]
		public override LMDLKPMFHFG AJHIJKHBOOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PEIDMNINPMC>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74C4D30", Offset = "0x74C3330", VA = "0x1874C4D30")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AC0", Offset = "0x74C40C0", VA = "0x1874C5AC0")]
		public MutableOverridableObscuredBool(bool NHKABEKLDED, ObscuredBool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74C59F0", Offset = "0x74C3FF0", VA = "0x1874C59F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74C5880", Offset = "0x74C3E80", VA = "0x1874C5880", Slot = "20")]
		public override void INPBGNOCMBE(byte[] MGHGDDFBKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74C57C0", Offset = "0x74C3DC0", VA = "0x1874C57C0", Slot = "19")]
		public override void HDOKFBFPFNM(PEIDMNINPMC FMPCPEMKMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74C56D0", Offset = "0x74C3CD0", VA = "0x1874C56D0", Slot = "18")]
		public override PEIDMNINPMC AJHIJKHBOOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74C5960", Offset = "0x74C3F60", VA = "0x1874C5960", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, AOHNBHBJCBL<ObscuredBool>, FOHMOMDGFGF<ObscuredBool>, HEFCBGFIADE<ObscuredBool>, AAMPBNIOAAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x956CA0", Offset = "0x9552A0", VA = "0x180956CA0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74C4D30", Offset = "0x74C3330", VA = "0x1874C4D30")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74C4CB0", Offset = "0x74C32B0", VA = "0x1874C4CB0")]
		public void KJHFOMGAEOH(MutableOverridableDefaultableObscuredBool OKCHLIEAIJP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PCELLPEENHC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x531CEB0", Offset = "0x531B4B0", VA = "0x18531CEB0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x531D030", Offset = "0x531B630", VA = "0x18531D030", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44356C0", Offset = "0x4433CC0", VA = "0x1844356C0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x531CE70", Offset = "0x531B470", VA = "0x18531CE70")]
		public SerializedMutableOverridableObscuredEnum(bool NHKABEKLDED, TObsEnum KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x531CB20", Offset = "0x531B120", VA = "0x18531CB20", Slot = "18")]
		public sealed override PCELLPEENHC AJHIJKHBOOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x531CC10", Offset = "0x531B210", VA = "0x18531CC10", Slot = "19")]
		public sealed override void HDOKFBFPFNM(PCELLPEENHC FMPCPEMKMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x531CD10", Offset = "0x531B310", VA = "0x18531CD10", Slot = "20")]
		public sealed override void INPBGNOCMBE(byte[] MGHGDDFBKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x531CDF0", Offset = "0x531B3F0", VA = "0x18531CDF0", Slot = "17")]
		public sealed override void KLOHADBCHCL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MIIKFIKLKGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x74C5600", Offset = "0x74C3C00", VA = "0x1874C5600", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x74C5640", Offset = "0x74C3C40", VA = "0x1874C5640", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74C5560", Offset = "0x74C3B60", VA = "0x1874C5560")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74C5500", Offset = "0x74C3B00", VA = "0x1874C5500")]
		public MutableOverridableListObscuredString(bool NHKABEKLDED, List<ObscuredString> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74C5460", Offset = "0x74C3A60", VA = "0x1874C5460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74C53D0", Offset = "0x74C39D0", VA = "0x1874C53D0", Slot = "17")]
		public override void KLOHADBCHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74C52F0", Offset = "0x74C38F0", VA = "0x1874C52F0", Slot = "20")]
		public override void INPBGNOCMBE(byte[] MGHGDDFBKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74C4F80", Offset = "0x74C3580", VA = "0x1874C4F80", Slot = "19")]
		public override void HDOKFBFPFNM(MIIKFIKLKGJ FMPCPEMKMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74C4DA0", Offset = "0x74C33A0", VA = "0x1874C4DA0", Slot = "18")]
		public override MIIKFIKLKGJ AJHIJKHBOOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : HEFCBGFIADE<Vector3>, AAMPBNIOAAP
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
			[Cpp2IlInjected.Address(RVA = "0xD77BA0", Offset = "0xD761A0", VA = "0x180D77BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x74C6590", Offset = "0x74C4B90", VA = "0x1874C6590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4B9F130", Offset = "0x4B9D730", VA = "0x184B9F130", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4FB2A00", Offset = "0x4FB1000", VA = "0x184FB2A00")]
		public OverridableVector3(Vector3 KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x55EDAC0", Offset = "0x55EC0C0", VA = "0x1855EDAC0")]
		public OverridableVector3(bool NHKABEKLDED, Vector3 KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74C64F0", Offset = "0x74C4AF0", VA = "0x1874C64F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x74C64D0", Offset = "0x74C4AD0", VA = "0x1874C64D0")]
		public static OverridableVector3 HEGJABMHLEC(Vector3 DGOEGFOLJJL)
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
