using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.OverridableFields
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface INTRCRVSTPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface YBFYUSOXJRP<a> : INTRCRVSTPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface VBHUUPLRJBD<a> : YBFYUSOXJRP<a>, INTRCRVSTPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		new bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		new a Value
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
	public interface SHRTSPWQONA<a> : VBHUUPLRJBD<a>, YBFYUSOXJRP<a>, INTRCRVSTPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ZJJJKHPHIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9814580", Offset = "0x9812F80", VA = "0x189814580")]
		public static float? GIUUQVWBFNU(this OverridableFloat a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : YBFYUSOXJRP<int>, INTRCRVSTPA
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
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x10ADD60", Offset = "0x10AC760", VA = "0x1810ADD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x98143E0", Offset = "0x9812DE0", VA = "0x1898143E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x30C2C60", Offset = "0x30C1660", VA = "0x1830C2C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9814360", Offset = "0x9812D60", VA = "0x189814360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableFloat : YBFYUSOXJRP<float>, INTRCRVSTPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x10ADD60", Offset = "0x10AC760", VA = "0x1810ADD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9814330", Offset = "0x9812D30", VA = "0x189814330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2E35770", Offset = "0x2E34170", VA = "0x182E35770", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x98142B0", Offset = "0x9812CB0", VA = "0x1898142B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OverridableString : YBFYUSOXJRP<string>, INTRCRVSTPA
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
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x10ADD60", Offset = "0x10AC760", VA = "0x1810ADD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9814410", Offset = "0x9812E10", VA = "0x189814410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class LMFDLSNEVHX<a, b, c> : VBHUUPLRJBD<b>, YBFYUSOXJRP<b>, INTRCRVSTPA where a : LMFDLSNEVHX<a, b, c> where c : IMessage<c>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract b Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2DB3AE0", Offset = "0x2DB24E0", VA = "0x182DB3AE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6930380", Offset = "0x692ED80", VA = "0x186930380")]
		public LMFDLSNEVHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69303B0", Offset = "0x692EDB0", VA = "0x1869303B0")]
		public LMFDLSNEVHX(bool a, [NotNull] b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x692FB60", Offset = "0x692E560", VA = "0x18692FB60", Slot = "15")]
		public void OBSRGQGWULN(YBFYUSOXJRP<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x692F700", Offset = "0x692E100", VA = "0x18692F700", Slot = "16")]
		public void Copy(YBFYUSOXJRP<b> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6930060", Offset = "0x692EA60", VA = "0x186930060", Slot = "17")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract c XWHIHLJHGIO();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void CWDCHBJWYIG(c a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void YQMJHWPXTRP(byte[] a);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : LMFDLSNEVHX<T, InnerType, ProtobufType> where T : LMFDLSNEVHX<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
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
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xDE7AB0", Offset = "0xDE64B0", VA = "0x180DE7AB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xF6EBE0", Offset = "0xF6D5E0", VA = "0x180F6EBE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79F0DE0", Offset = "0x79EF7E0", VA = "0x1879F0DE0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x79F0F60", Offset = "0x79EF960", VA = "0x1879F0F60")]
		public SerializedMutableOverridableBase(bool overrides, InnerType value)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, YHVZJYSLWNC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98141E0", Offset = "0x9812BE0", VA = "0x1898141E0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9814240", Offset = "0x9812C40", VA = "0x189814240")]
		public MutableOverridableObscuredInt(bool overrides, ObscuredInt value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9813F60", Offset = "0x9812960", VA = "0x189813F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9814100", Offset = "0x9812B00", VA = "0x189814100", Slot = "20")]
		public override void YQMJHWPXTRP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9813EB0", Offset = "0x98128B0", VA = "0x189813EB0", Slot = "19")]
		public override void CWDCHBJWYIG(YHVZJYSLWNC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9814020", Offset = "0x9812A20", VA = "0x189814020", Slot = "18")]
		public override YHVZJYSLWNC XWHIHLJHGIO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, YFKSEZTQBJB>
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9813DE0", Offset = "0x98127E0", VA = "0x189813DE0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9813E40", Offset = "0x9812840", VA = "0x189813E40")]
		public MutableOverridableObscuredFloat(bool overrides, ObscuredFloat value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9813B40", Offset = "0x9812540", VA = "0x189813B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9813D00", Offset = "0x9812700", VA = "0x189813D00", Slot = "20")]
		public override void YQMJHWPXTRP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9813A80", Offset = "0x9812480", VA = "0x189813A80", Slot = "19")]
		public override void CWDCHBJWYIG(YFKSEZTQBJB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9813C10", Offset = "0x9812610", VA = "0x189813C10", Slot = "18")]
		public override YFKSEZTQBJB XWHIHLJHGIO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, NLYPSGQYUDR>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9812CE0", Offset = "0x98116E0", VA = "0x189812CE0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9813A10", Offset = "0x9812410", VA = "0x189813A10")]
		public MutableOverridableObscuredBool(bool overrides, ObscuredBool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9813780", Offset = "0x9812180", VA = "0x189813780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9813930", Offset = "0x9812330", VA = "0x189813930", Slot = "20")]
		public override void YQMJHWPXTRP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9813630", Offset = "0x9812030", VA = "0x189813630", Slot = "19")]
		public override void CWDCHBJWYIG(NLYPSGQYUDR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9813850", Offset = "0x9812250", VA = "0x189813850", Slot = "18")]
		public override NLYPSGQYUDR XWHIHLJHGIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98136F0", Offset = "0x98120F0", VA = "0x1898136F0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, SHRTSPWQONA<ObscuredBool>, VBHUUPLRJBD<ObscuredBool>, YBFYUSOXJRP<ObscuredBool>, INTRCRVSTPA
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9812CE0", Offset = "0x98116E0", VA = "0x189812CE0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9812C60", Offset = "0x9811660", VA = "0x189812C60")]
		public void OBSRGQGWULN(MutableOverridableDefaultableObscuredBool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, YHVZJYSLWNC> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x79F19A0", Offset = "0x79F03A0", VA = "0x1879F19A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x79F1C10", Offset = "0x79F0610", VA = "0x1879F1C10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79F1900", Offset = "0x79F0300", VA = "0x1879F1900")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79F1980", Offset = "0x79F0380", VA = "0x1879F1980")]
		public SerializedMutableOverridableObscuredEnum(bool overrides, TObsEnum value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79F1540", Offset = "0x79EFF40", VA = "0x1879F1540", Slot = "18")]
		public sealed override YHVZJYSLWNC XWHIHLJHGIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x79F1260", Offset = "0x79EFC60", VA = "0x1879F1260", Slot = "19")]
		public sealed override void CWDCHBJWYIG(YHVZJYSLWNC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x79F1820", Offset = "0x79F0220", VA = "0x1879F1820", Slot = "20")]
		public sealed override void YQMJHWPXTRP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x79F14E0", Offset = "0x79EFEE0", VA = "0x1879F14E0", Slot = "17")]
		public sealed override void Reset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, MXRGNDRBHEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9813560", Offset = "0x9811F60", VA = "0x189813560", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x98135A0", Offset = "0x9811FA0", VA = "0x1898135A0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98134D0", Offset = "0x9811ED0", VA = "0x1898134D0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9813470", Offset = "0x9811E70", VA = "0x189813470")]
		public MutableOverridableListObscuredString(bool overrides, List<ObscuredString> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9813120", Offset = "0x9811B20", VA = "0x189813120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9813090", Offset = "0x9811A90", VA = "0x189813090", Slot = "17")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9813390", Offset = "0x9811D90", VA = "0x189813390", Slot = "20")]
		public override void YQMJHWPXTRP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9812D50", Offset = "0x9811750", VA = "0x189812D50", Slot = "19")]
		public override void CWDCHBJWYIG(MXRGNDRBHEC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98131B0", Offset = "0x9811BB0", VA = "0x1898131B0", Slot = "18")]
		public override MXRGNDRBHEC XWHIHLJHGIO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OverridableVector3 : YBFYUSOXJRP<Vector3>, INTRCRVSTPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10ADD60", Offset = "0x10AC760", VA = "0x1810ADD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9814510", Offset = "0x9812F10", VA = "0x189814510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD37330", Offset = "0xD35D30", VA = "0x180D37330", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73AB940", Offset = "0x73AA340", VA = "0x1873AB940")]
		public OverridableVector3(Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x80B59F0", Offset = "0x80B43F0", VA = "0x1880B59F0")]
		public OverridableVector3(bool overrides, Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9814470", Offset = "0x9812E70", VA = "0x189814470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9814560", Offset = "0x9812F60", VA = "0x189814560")]
		public static implicit operator OverridableVector3(Vector3 val)
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
