using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x742C830", Offset = "0x742BC30", VA = "0x18742C830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EKEHNNDIDIK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE790", Offset = "0x1DEDB90", VA = "0x181DEE790")]
	public EKEHNNDIDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GJNJIONJAFL, AKLCOKKIAMD, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MGPEIJNPFNJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA3C8E0", Offset = "0xA3BCE0", VA = "0x180A3C8E0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x742DAB0", Offset = "0x742CEB0", VA = "0x18742DAB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x742DA70", Offset = "0x742CE70", VA = "0x18742DA70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x742DAF0", Offset = "0x742CEF0", VA = "0x18742DAF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x742DCA0", Offset = "0x742D0A0", VA = "0x18742DCA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x742DC10", Offset = "0x742D010", VA = "0x18742DC10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD6B510", Offset = "0xD6A910", VA = "0x180D6B510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBDA170", Offset = "0xBD9570", VA = "0x180BDA170")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x742DA30", Offset = "0x742CE30", VA = "0x18742DA30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x742DB80", Offset = "0x742CF80", VA = "0x18742DB80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x742D4D0", Offset = "0x742C8D0", VA = "0x18742D4D0")]
	public void CopyBounds(SavedExtents OKCHLIEAIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x742D980", Offset = "0x742CD80", VA = "0x18742D980")]
	public void SetLocalSpaceBounds(Bounds KLCGDCHIPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11D66E0", Offset = "0x11D5AE0", VA = "0x1811D66E0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x742D970", Offset = "0x742CD70", VA = "0x18742D970")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x742D500", Offset = "0x742C900", VA = "0x18742D500")]
	private void GHEEMHAKDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x742D770", Offset = "0x742CB70", VA = "0x18742D770")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x742CE60", Offset = "0x742C260", VA = "0x18742CE60")]
	public static void CalculateLocalBoundsFor(GameObject HHDLNMHBJJD, [Out] Bounds KLCGDCHIPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x742D6B0", Offset = "0x742CAB0", VA = "0x18742D6B0")]
	private static void MBHOMJJMPAG(Bounds PPCFCAEIJMM, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x742D9A0", Offset = "0x742CDA0", VA = "0x18742D9A0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x166C940", Offset = "0x166BD40", VA = "0x18166C940")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x52BC080", Offset = "0x52BB480", VA = "0x1852BC080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public virtual void JDDJGPDOBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52BBBF0", Offset = "0x52BAFF0", VA = "0x1852BBBF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x52BA7C0", Offset = "0x52B9BC0", VA = "0x1852BA7C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52BBFA0", Offset = "0x52BB3A0", VA = "0x1852BBFA0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BGJJGABNIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BGJJGABNIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x583C580", Offset = "0x583B980", VA = "0x18583C580")]
		internal int BEMCIDOBLFC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x402FB90", Offset = "0x402EF90", VA = "0x18402FB90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x402FBF0", Offset = "0x402EFF0", VA = "0x18402FBF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x402FA70", Offset = "0x402EE70", VA = "0x18402FA70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LKMGECEEGEE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x402FB30", Offset = "0x402EF30", VA = "0x18402FB30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x402F920", Offset = "0x402ED20", VA = "0x18402F920", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x402F530", Offset = "0x402E930", VA = "0x18402F530", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x402E8F0", Offset = "0x402DCF0", VA = "0x18402E8F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x402F710", Offset = "0x402EB10", VA = "0x18402F710", Slot = "14")]
	protected virtual string POHGANAOPIG(TKeyVal ONFJMGPMMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x402E7F0", Offset = "0x402DBF0", VA = "0x18402E7F0", Slot = "4")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x402F7A0", Offset = "0x402EBA0", VA = "0x18402F7A0", Slot = "5")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x402E850", Offset = "0x402DC50", VA = "0x18402E850", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x402E850", Offset = "0x402DC50", VA = "0x18402E850", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x402F800", Offset = "0x402EC00", VA = "0x18402F800")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x52BDA70", Offset = "0x52BCE70", VA = "0x1852BDA70")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x52BD2B0", Offset = "0x52BC6B0", VA = "0x1852BD2B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x52BC860", Offset = "0x52BBC60", VA = "0x1852BC860", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class BDMKJAENPEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EADFPOHNMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float MPAJGOMHHLL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int MFAMJBCHJLN = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FAKCCAHJMJM = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly EADFPOHNMLA[] CJFOOLJEHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int BLHHOFFHFDA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CCOGJBBLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAA9170", Offset = "0xAA8570", VA = "0x180AA9170")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAF6040", Offset = "0xAF5440", VA = "0x180AF6040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T IJOKMEENCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5838160", Offset = "0x5837560", VA = "0x185838160")]
	protected BDMKJAENPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58380C0", Offset = "0x58374C0", VA = "0x1858380C0")]
	protected BDMKJAENPEG(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5837EE0", Offset = "0x58372E0", VA = "0x185837EE0")]
	public void HBHDBABAKDP(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PIBBGNLICCF(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool FPONNCIDEJI(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5837FF0", Offset = "0x58373F0", VA = "0x185837FF0")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDLPKPIGIHE : BDMKJAENPEG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x742AE10", Offset = "0x742A210", VA = "0x18742AE10", Slot = "4")]
	public override bool PIBBGNLICCF(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] Vector3 KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x742ACD0", Offset = "0x742A0D0", VA = "0x18742ACD0", Slot = "5")]
	public override bool FPONNCIDEJI(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] Vector3 KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x742AF70", Offset = "0x742A370", VA = "0x18742AF70")]
	public HDLPKPIGIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EIALEOFKHJH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3227FF0", Offset = "0x32273F0", VA = "0x183227FF0")]
	public static CANEJCIOAKL<T1, T2> OILMBKHFGKP<T1, T2>(T1 GBBKNPJIAFP, T2 BGIPELEGIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3228090", Offset = "0x3227490", VA = "0x183228090")]
	public static BBDPDAJNEAB<T1, T2, T3> OILMBKHFGKP<T1, T2, T3>(T1 GBBKNPJIAFP, T2 BGIPELEGIPK, T3 MOOIKGDOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E0DC30", Offset = "0x4E0D030", VA = "0x184E0DC30")]
	internal static int ICMJHMEEHHA(int BEHOJNPABMJ, int LHBGKAHLPEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x670D990", Offset = "0x670CD90", VA = "0x18670D990")]
	internal static int ICMJHMEEHHA(int BEHOJNPABMJ, int LHBGKAHLPEJ, int MPEAEKJOCEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CANEJCIOAKL<T1, T2> : IComparable<CANEJCIOAKL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 ECAKFCOMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 BOHFFOLPHFN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x594A8D0", Offset = "0x5949CD0", VA = "0x18594A8D0")]
	public CANEJCIOAKL(T1 GBBKNPJIAFP, T2 BGIPELEGIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5948B80", Offset = "0x5947F80", VA = "0x185948B80", Slot = "4")]
	public int CompareTo(CANEJCIOAKL<T1, T2> OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5949180", Offset = "0x5948580", VA = "0x185949180", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5949C30", Offset = "0x5949030", VA = "0x185949C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x594A100", Offset = "0x5949500", VA = "0x18594A100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBDPDAJNEAB<T1, T2, T3> : IComparable<BBDPDAJNEAB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 ECAKFCOMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 BOHFFOLPHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 AOPMNFAFLHC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x58363A0", Offset = "0x58357A0", VA = "0x1858363A0")]
	public BBDPDAJNEAB(T1 GBBKNPJIAFP, T2 BGIPELEGIPK, T3 MOOIKGDOEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5835A30", Offset = "0x5834E30", VA = "0x185835A30", Slot = "4")]
	public int CompareTo(BBDPDAJNEAB<T1, T2, T3> OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5835E00", Offset = "0x5835200", VA = "0x185835E00", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5835FB0", Offset = "0x58353B0", VA = "0x185835FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x58361F0", Offset = "0x58355F0", VA = "0x1858361F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve MEKOEBHOABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T BKDFHECHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x10A2730", Offset = "0x10A1B30", VA = "0x1810A2730")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HHFDJFGAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA998F0", Offset = "0xA98CF0", VA = "0x180A998F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29016A0", Offset = "0x2900AA0", VA = "0x1829016A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29018F0", Offset = "0x2900CF0", VA = "0x1829018F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KLMKKBNCOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA92A90", Offset = "0xA91E90", VA = "0x180A92A90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x553FC20", Offset = "0x553F020", VA = "0x18553FC20")]
	public T CAODICGHFIO(float CHBEBLKFDBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5540120", Offset = "0x553F520", VA = "0x185540120")]
	public T MNBIGCGLFEE(float CHBEBLKFDBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KBBDEOMJCFA(T CLHNCHKFPON, T KMNANLEEDKO, float CHBEBLKFDBC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x742AB90", Offset = "0x7429F90", VA = "0x18742AB90", Slot = "4")]
	protected override float KBBDEOMJCFA(float CLHNCHKFPON, float KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x742ABD0", Offset = "0x7429FD0", VA = "0x18742ABD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x14EA970", Offset = "0x14E9D70", VA = "0x1814EA970", Slot = "4")]
	protected override Vector3 KBBDEOMJCFA(Vector3 CLHNCHKFPON, Vector3 KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x742EAB0", Offset = "0x742DEB0", VA = "0x18742EAB0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74289A0", Offset = "0x7427DA0", VA = "0x1874289A0", Slot = "4")]
	protected override Color KBBDEOMJCFA(Color CLHNCHKFPON, Color KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7428A60", Offset = "0x7427E60", VA = "0x187428A60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AOIEJOLMHIO : PGPEJIODKCL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74286B0", Offset = "0x7427AB0", VA = "0x1874286B0")]
	public AOIEJOLMHIO(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7428640", Offset = "0x7427A40", VA = "0x187428640", Slot = "6")]
	protected override uint DPOHEDINKDL(uint MGPEIJNPFNJ, string KBGCCIOIGBD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BAJBDNNJIPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public BAJBDNNJIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NDANCIKFOCO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FFGHBHLDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BCFCGIBGIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int AOPNFALECDA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4E0FE30", Offset = "0x4E0F230", VA = "0x184E0FE30")]
	private NDANCIKFOCO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PKGIOODIPNM, int AGBKCKBBIIL, int IENEKJIPKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E20EC0", Offset = "0x4E202C0", VA = "0x184E20EC0")]
	public static NDANCIKFOCO<T> FEOBEKOIKMG()
	{
		return default(NDANCIKFOCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E216E0", Offset = "0x4E20AE0", VA = "0x184E216E0")]
	public (int, int, Task<T>) FPHFDELOAPN(int CGHBAOIKKLL, [Optional] CancellationToken LAEIHJHNGEK, double HKPDGGGHFLH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E22E50", Offset = "0x4E22250", VA = "0x184E22E50")]
	public void NBJFHPDHLPA(int CGHBAOIKKLL, int IENEKJIPKDG, [In] T BIEIOPPGBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BEGJFHNCNPJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74287E0", Offset = "0x7427BE0", VA = "0x1874287E0")]
	public static NDANCIKFOCO<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return default(NDANCIKFOCO<IDMEFNAINAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7428830", Offset = "0x7427C30", VA = "0x187428830")]
	public static void NBJFHPDHLPA([In] this NDANCIKFOCO<IDMEFNAINAN> JDCFMPOHCEA, int CGHBAOIKKLL, int IENEKJIPKDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MIPJNHEPHAG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> JIELCLBMFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> BJGAAHFPGEI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDFC0", Offset = "0x3CFD3C0", VA = "0x183CFDFC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> OLFFBNADHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4505CE0", Offset = "0x45050E0", VA = "0x184505CE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x44FF560", Offset = "0x44FE960", VA = "0x1844FF560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4D90BF0", Offset = "0x4D8FFF0", VA = "0x184D90BF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4D90C90", Offset = "0x4D90090", VA = "0x184D90C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4D90680", Offset = "0x4D8FA80", VA = "0x184D90680")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D902D0", Offset = "0x4D8F6D0", VA = "0x184D902D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D909D0", Offset = "0x4D8FDD0", VA = "0x184D909D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D8FFE0", Offset = "0x4D8F3E0", VA = "0x184D8FFE0", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D90030", Offset = "0x4D8F430", VA = "0x184D90030", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4D90370", Offset = "0x4D8F770", VA = "0x184D90370", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D903C0", Offset = "0x4D8F7C0", VA = "0x184D903C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D90910", Offset = "0x4D8FD10", VA = "0x184D90910", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D90990", Offset = "0x4D8FD90", VA = "0x184D90990", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D90A70", Offset = "0x4D8FE70", VA = "0x184D90A70", Slot = "11")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D90580", Offset = "0x4D8F980", VA = "0x184D90580", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D90440", Offset = "0x4D8F840", VA = "0x184D90440", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D90520", Offset = "0x4D8F920", VA = "0x184D90520")]
	public bool GMJNAAAPBAP(TVal LKMGECEEGEE, [Out] TKey KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4D8FE20", Offset = "0x4D8F220", VA = "0x184D8FE20")]
	private void ACLKKFBGJDN(TKey LKMGECEEGEE, TVal DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D90110", Offset = "0x4D8F510", VA = "0x184D90110")]
	private void CGDGAPFFMIN(TKey LKMGECEEGEE, TVal DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4D907F0", Offset = "0x4D8FBF0", VA = "0x184D907F0")]
	private bool LFGMPFNBDCL(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D90AD0", Offset = "0x4D8FED0", VA = "0x184D90AD0")]
	public MIPJNHEPHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class GPDIDABDGDI<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GPDIDABDGDI<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1073570", Offset = "0x1072970", VA = "0x181073570", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4090C10", Offset = "0x4090010", VA = "0x184090C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x40920A0", Offset = "0x40914A0", VA = "0x1840920A0")]
		public Enumerator(GPDIDABDGDI<T> DEEIKCMDENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x408F930", Offset = "0x408ED30", VA = "0x18408F930", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4090770", Offset = "0x408FB70", VA = "0x184090770", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4090610", Offset = "0x408FA10", VA = "0x184090610")]
		private void PMDEHNIEOEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] ONOIJFJJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EKDINNHMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PHHAFJOKPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EPKMALKPPHD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4565AA0", Offset = "0x4564EA0", VA = "0x184565AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x45657A0", Offset = "0x4564BA0", VA = "0x1845657A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4564820", Offset = "0x4563C20", VA = "0x184564820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4565DC0", Offset = "0x45651C0", VA = "0x184565DC0")]
	public GPDIDABDGDI(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4564E30", Offset = "0x4564230", VA = "0x184564E30")]
	public void HBHDBABAKDP(T CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45659B0", Offset = "0x4564DB0", VA = "0x1845659B0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45659D0", Offset = "0x4564DD0", VA = "0x1845659D0")]
	public void KPINJGJFDAH(int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4563D40", Offset = "0x4563140", VA = "0x184563D40")]
	public void DCNHFJIJBBF(T[] CJFOOLJEHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4563CD0", Offset = "0x45630D0", VA = "0x184563CD0")]
	public Enumerator BNIMLGJMJBK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4565B60", Offset = "0x4564F60", VA = "0x184565B60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4565B60", Offset = "0x4564F60", VA = "0x184565B60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4565310", Offset = "0x4564710", VA = "0x184565310")]
	private int JCHKHMJJKEH(int EAHKFAJBNDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4564F50", Offset = "0x4564350", VA = "0x184564F50")]
	private int IPEJKBMEKHF(int EAHKFAJBNDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EDKFEDBHBOL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> JFGBDKDLEJL(TRequest NEMAHPGAGLG, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AAHNIMPLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class CJMJPGJKLEL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float IMHAHMHMNAP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan MGMHIEBDNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NLALFEJCGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AAHNIMPLBFA FKLKEDMMMAE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly CJMJPGJKLEL MPDPNCAPBBE;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ECKECGACNLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5B268D0", Offset = "0x5B25CD0", VA = "0x185B268D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan CAFIDJCMIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5B26A20", Offset = "0x5B25E20", VA = "0x185B26A20")]
		public CJMJPGJKLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PAKFHMBJKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest NEMAHPGAGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken LAEIHJHNGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> MECOEADPMKH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x506D230", Offset = "0x506C630", VA = "0x18506D230")]
		public PAKFHMBJKLL(TRequest NEMAHPGAGLG, TaskCompletionSource<TResult> MECOEADPMKH, CancellationToken LAEIHJHNGEK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct IONJFGBHOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EDKFEDBHBOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x473DF30", Offset = "0x473D330", VA = "0x18473DF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x473E330", Offset = "0x473D730", VA = "0x18473E330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MFBCMJCIELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EDKFEDBHBOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PAKFHMBJKLL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B000", Offset = "0x4D6A400", VA = "0x184D6B000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C230", Offset = "0x4D6B630", VA = "0x184D6C230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource ABJBANGOLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<PAKFHMBJKLL> MEHFPGDCPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CJMJPGJKLEL ADOJODGNLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JFGBDKDLEJL OFEJHKIKBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task AOPMJENHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LGBEMPAJIMF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3FFAF10", Offset = "0x3FFA310", VA = "0x183FFAF10")]
	public EDKFEDBHBOL(JFGBDKDLEJL OFEJHKIKBPG, [Optional] CJMJPGJKLEL ADOJODGNLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9940", Offset = "0x3FF8D40", VA = "0x183FF9940")]
	public Task<TResult> BMAKLANMMBJ(TRequest NEMAHPGAGLG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3FFA740", Offset = "0x3FF9B40", VA = "0x183FFA740")]
	private void KIELEBCOCGC(PAKFHMBJKLL CKHHAIMJCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3FFAB60", Offset = "0x3FF9F60", VA = "0x183FFAB60")]
	[AsyncStateMachine(typeof(EDKFEDBHBOL<, >.IONJFGBHOHC))]
	private Task OEDHGHDEGDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9EA0", Offset = "0x3FF92A0", VA = "0x183FF9EA0")]
	private PAKFHMBJKLL IGJBNFDMGEF()
	{
		return default(PAKFHMBJKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FFAE20", Offset = "0x3FFA220", VA = "0x183FFAE20")]
	[AsyncStateMachine(typeof(EDKFEDBHBOL<, >.MFBCMJCIELI))]
	private Task OFPCMPIDPAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9C60", Offset = "0x3FF9060", VA = "0x183FF9C60")]
	private void DAKFNFOACNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9E60", Offset = "0x3FF9260", VA = "0x183FF9E60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class GCINEMJDAHE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> BHMKCPLLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> DFDAIABIAHM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDFC0", Offset = "0x3CFD3C0", VA = "0x183CFDFC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3410ED0", Offset = "0x34102D0", VA = "0x183410ED0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4478C30", Offset = "0x4478030", VA = "0x184478C30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x43EFE20", Offset = "0x43EF220", VA = "0x1843EFE20", Slot = "11")]
	public void Add(T MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4478300", Offset = "0x4477700", VA = "0x184478300")]
	public bool HFHDPLKFOBI(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4478990", Offset = "0x4477D90", VA = "0x184478990", Slot = "15")]
	public bool Remove(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4478170", Offset = "0x4477570", VA = "0x184478170", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4442FB0", Offset = "0x44423B0", VA = "0x184442FB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4478020", Offset = "0x4477420", VA = "0x184478020", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x44780C0", Offset = "0x44774C0", VA = "0x1844780C0", Slot = "13")]
	public bool Contains(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4478110", Offset = "0x4477510", VA = "0x184478110", Slot = "14")]
	public void CopyTo(T[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4478400", Offset = "0x4477800", VA = "0x184478400", Slot = "6")]
	public int IndexOf(T MBDDOPABDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4478460", Offset = "0x4477860", VA = "0x184478460", Slot = "7")]
	public void Insert(int EAHKFAJBNDN, T MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x44786F0", Offset = "0x4477AF0", VA = "0x1844786F0", Slot = "8")]
	public void RemoveAt(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4478B10", Offset = "0x4477F10", VA = "0x184478B10")]
	public GCINEMJDAHE()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x277E5B0", Offset = "0x277D9B0", VA = "0x18277E5B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x742E040", Offset = "0x742D440", VA = "0x18742E040")]
		public SerializedGuid([In] Guid JINNLDEOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x742DE40", Offset = "0x742D240", VA = "0x18742DE40")]
		public static SerializedGuid HKBELKAOBLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x742DEC0", Offset = "0x742D2C0", VA = "0x18742DEC0")]
		public static SerializedGuid OBOALHDENEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x742DFE0", Offset = "0x742D3E0", VA = "0x18742DFE0")]
		public bool PMLNJMJFBKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x742DFB0", Offset = "0x742D3B0", VA = "0x18742DFB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x742DF30", Offset = "0x742D330", VA = "0x18742DF30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x742DD60", Offset = "0x742D160", VA = "0x18742DD60", Slot = "7")]
		public bool Equals(SerializedGuid OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x742DDA0", Offset = "0x742D1A0", VA = "0x18742DDA0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x742DE30", Offset = "0x742D230", VA = "0x18742DE30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x742DD30", Offset = "0x742D130", VA = "0x18742DD30", Slot = "6")]
		public int CompareTo(SerializedGuid OKCHLIEAIJP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OHAMBBNIBBN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type JKPDLOBBLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string EOBJDAGFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AKIGJFICNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool PMJLEDPENKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x742C8B0", Offset = "0x742BCB0", VA = "0x18742C8B0")]
	public OHAMBBNIBBN(Type CNBCEOGAJPF, string MEBJKOKIDMA, bool KLLIJONGICL = false, bool NPPCDILNICE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, [Optional] float? FGFPILMKAEJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKIOKOIHHPE();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class JBOOKKIDKKF<T> : MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class CDPJFAOLCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float CAPILIHKBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CDPJFAOLCEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CHIHIDPAOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CHIHIDPAOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5A41900", Offset = "0x5A40D00", VA = "0x185A41900")]
		internal bool FMNGENOGKMD(CDPJFAOLCEK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float ABGKBLAGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float NBEFHOMJHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<CDPJFAOLCEK> GDLKGNBDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private AJBFHMILPDB<CDPJFAOLCEK> MMEBKBJJHHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4945E50", Offset = "0x4945250", VA = "0x184945E50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x49460E0", Offset = "0x49454E0", VA = "0x1849460E0")]
	public JBOOKKIDKKF(float ANDPFDICNMC, float ACJJKADAMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4945330", Offset = "0x4944730", VA = "0x184945330", Slot = "6")]
	public bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4945A30", Offset = "0x4944E30", VA = "0x184945A30", Slot = "5")]
	public IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, float? FGFPILMKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4945DA0", Offset = "0x49451A0", VA = "0x184945DA0", Slot = "7")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4945F30", Offset = "0x4945330", VA = "0x184945F30")]
	private void OOKABCBFHDO(float KGDKBIOOEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GPAEHHALEEJ<T> : MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GDDFCACDPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float CAPILIHKBGB;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x447D140", Offset = "0x447C540", VA = "0x18447D140")]
		public GDDFCACDPKA(T KBGCCIOIGBD, float KGDKBIOOEOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PMGOKNJDHBJ : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public GPAEHHALEEJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public PMGOKNJDHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x50AD620", Offset = "0x50ACA20", VA = "0x1850AD620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x50ADBA0", Offset = "0x50ACFA0", VA = "0x1850ADBA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x50ADA70", Offset = "0x50ACE70", VA = "0x1850ADA70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x45571B0", Offset = "0x45565B0", VA = "0x1845571B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float ANDPFDICNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float ACJJKADAMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<GDDFCACDPKA> GDLKGNBDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EKDINNHMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EIPDLABJDCE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4563940", Offset = "0x4562D40", VA = "0x184563940")]
	public GPAEHHALEEJ(float ANDPFDICNMC, float ACJJKADAMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4562EB0", Offset = "0x45622B0", VA = "0x184562EB0", Slot = "6")]
	public bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x45632F0", Offset = "0x45626F0", VA = "0x1845632F0", Slot = "8")]
	public int HOEIOPNDBAB(float KGDKBIOOEOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4563170", Offset = "0x4562570", VA = "0x184563170", Slot = "5")]
	[IteratorStateMachine(typeof(GPAEHHALEEJ<>.PMGOKNJDHBJ))]
	public IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, float? FGFPILMKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x45636B0", Offset = "0x4562AB0", VA = "0x1845636B0", Slot = "7")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x45635C0", Offset = "0x45629C0", VA = "0x1845635C0")]
	private void KELGPMBHFIM(float KGDKBIOOEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4563340", Offset = "0x4562740", VA = "0x184563340")]
	private GDDFCACDPKA ICMAGNOACJK()
	{
		return default(GDDFCACDPKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class FGFDKLMANEA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct LPKEPHHLKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long JBBOAGKKPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long EDBJIMKMBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int NGLDOEKHAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int AIIJBAECDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool FGGOBHBAMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string HCMCKPOLBNP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A210", Offset = "0x4B79610", VA = "0x184B7A210")]
		public LPKEPHHLKMM(long JBBOAGKKPIB, int NGLDOEKHAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A1E0", Offset = "0x4B795E0", VA = "0x184B7A1E0")]
		public LPKEPHHLKMM(long JBBOAGKKPIB, long EDBJIMKMBLL, int NGLDOEKHAPH, int AIIJBAECDCA, bool FGGOBHBAMOM, string HCMCKPOLBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A0F0", Offset = "0x4B794F0", VA = "0x184B7A0F0")]
		public int HNBOJAOAKOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A070", Offset = "0x4B79470", VA = "0x184B7A070")]
		public int BAGMOMHIFGB(int MMDHFPBBBFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A090", Offset = "0x4B79490", VA = "0x184B7A090")]
		public double GGCNPGPNNMP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A140", Offset = "0x4B79540", VA = "0x184B7A140")]
		public LPKEPHHLKMM JJFOMGBMLIM(long EDBJIMKMBLL, int AIIJBAECDCA)
		{
			return default(LPKEPHHLKMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ICBJPFEBGDJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct OGFNNEFACOE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public ICBJPFEBGDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<ICBJPFEBGDJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private ICBJPFEBGDJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4FA6870", Offset = "0x4FA5C70", VA = "0x184FA6870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4724380", Offset = "0x4723780", VA = "0x184724380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey PJGLJNJMAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly FGFDKLMANEA<TKey> ACNLNBKGHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly IBCMILIKEJG DDKJAEALMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<ICBJPFEBGDJ> MLLPPDFFEEE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string JGPLMPPFDGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4709500", Offset = "0x4708900", VA = "0x184709500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<ICBJPFEBGDJ> OAHIIDOOIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4709980", Offset = "0x4708D80", VA = "0x184709980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LPKEPHHLKMM EKIKCDGCDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x47094E0", Offset = "0x47088E0", VA = "0x1847094E0")]
			[CompilerGenerated]
			get
			{
				return default(LPKEPHHLKMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x47097A0", Offset = "0x4708BA0", VA = "0x1847097A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x47099C0", Offset = "0x4708DC0", VA = "0x1847099C0")]
		internal ICBJPFEBGDJ(FGFDKLMANEA<TKey> ACNLNBKGHCE, TKey LKMGECEEGEE, IBCMILIKEJG DDKJAEALMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x47097D0", Offset = "0x4708BD0", VA = "0x1847097D0")]
		public ICBJPFEBGDJ NGDEIMEMDOG(TKey LKMGECEEGEE, [Optional] IBCMILIKEJG? ELDBAGFCBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3556960", Offset = "0x3555D60", VA = "0x183556960")]
		[AsyncStateMachine(typeof(OGFNNEFACOE<>))]
		public Task<T> FKMHKIANPDK<T>(TKey LKMGECEEGEE, Func<ICBJPFEBGDJ, Task<T>> BPHLLBLGCAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4709550", Offset = "0x4708950", VA = "0x184709550", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HIMBHPNHKPI : IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, LPKEPHHLKMM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FGFDKLMANEA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, LPKEPHHLKMM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, LPKEPHHLKMM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x276A520", Offset = "0x2769920", VA = "0x18276A520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPKEPHHLKMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4618CA0", Offset = "0x46180A0", VA = "0x184618CA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x276A610", Offset = "0x2769A10", VA = "0x18276A610")]
		[DebuggerHidden]
		public HIMBHPNHKPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x43C42E0", Offset = "0x43C36E0", VA = "0x1843C42E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4618720", Offset = "0x4617B20", VA = "0x184618720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x46186D0", Offset = "0x4617AD0", VA = "0x1846186D0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4618C50", Offset = "0x4618050", VA = "0x184618C50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4618B80", Offset = "0x4617F80", VA = "0x184618B80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x43DEF20", Offset = "0x43DE320", VA = "0x1843DEF20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FLHHJDBGHKG : IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, LPKEPHHLKMM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private ICBJPFEBGDJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public ICBJPFEBGDJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FGFDKLMANEA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<ICBJPFEBGDJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, LPKEPHHLKMM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, LPKEPHHLKMM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x276A520", Offset = "0x2769920", VA = "0x18276A520", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPKEPHHLKMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x43D6BD0", Offset = "0x43D5FD0", VA = "0x1843D6BD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x276A610", Offset = "0x2769A10", VA = "0x18276A610")]
		[DebuggerHidden]
		public FLHHJDBGHKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x43D6C30", Offset = "0x43D6030", VA = "0x1843D6C30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x43D6280", Offset = "0x43D5680", VA = "0x1843D6280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x43D61C0", Offset = "0x43D55C0", VA = "0x1843D61C0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x43D6220", Offset = "0x43D5620", VA = "0x1843D6220")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x43D6B80", Offset = "0x43D5F80", VA = "0x1843D6B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x43D6A40", Offset = "0x43D5E40", VA = "0x1843D6A40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x43D6B40", Offset = "0x43D5F40", VA = "0x1843D6B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<FGFDKLMANEA<TKey>, IBCMILIKEJG> CODDEAMCOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ICBJPFEBGDJ OJFJOFOPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int BKCDJKHDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch CFOIMBGPCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int CPANNGAJEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string LHNBBDGOACI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICBJPFEBGDJ ACNMAEGKFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string JGPLMPPFDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43C78B0", Offset = "0x43C6CB0", VA = "0x1843C78B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x43C7B60", Offset = "0x43C6F60", VA = "0x1843C7B60")]
	public FGFDKLMANEA(TKey AMMHLMPHJNC, IBCMILIKEJG DDKJAEALMGF, [Optional] int? NGLDOEKHAPH, [Optional][CanBeNull] Stopwatch CFOIMBGPCMC, [Optional] Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA, [Optional] Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH, [Optional] Action<FGFDKLMANEA<TKey>, IBCMILIKEJG> CODDEAMCOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x43C7910", Offset = "0x43C6D10", VA = "0x1843C7910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x43C79E0", Offset = "0x43C6DE0", VA = "0x1843C79E0")]
	[IteratorStateMachine(typeof(FGFDKLMANEA<>.HIMBHPNHKPI))]
	public IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)> OKKDBNIAAHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x43C7A80", Offset = "0x43C6E80", VA = "0x1843C7A80")]
	[IteratorStateMachine(typeof(FGFDKLMANEA<>.FLHHJDBGHKG))]
	private IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)> OKKDBNIAAHF(List<TKey> DPEONNMDCPO, ICBJPFEBGDJ NHGJLMMOIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x43C7830", Offset = "0x43C6C30", VA = "0x1843C7830")]
	private (long, int) BGFEMNIAACL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class MGAAGOHENGF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected MGAAGOHENGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class OOPCMCOFIFC<TKey> : MGAAGOHENGF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string FDMMDEFCIPJ(TKey LKMGECEEGEE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4FD42A0", Offset = "0x4FD36A0", VA = "0x184FD42A0")]
	private static string LBGCFAIHGFJ(TKey LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4FD42E0", Offset = "0x4FD36E0", VA = "0x184FD42E0", Slot = "4")]
	public override string OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4FD43C0", Offset = "0x4FD37C0", VA = "0x184FD43C0")]
	public string OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE, [NotNull] FDMMDEFCIPJ CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DFODICCKMEC(FGFDKLMANEA<TKey> ACNLNBKGHCE, [NotNull] FDMMDEFCIPJ CFAPLNKNFIH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x43DBAE0", Offset = "0x43DAEE0", VA = "0x1843DBAE0")]
	protected OOPCMCOFIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KIBLFINBBBG<TKey> : MGAAGOHENGF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string ALNNMPMNKOO(TKey LKMGECEEGEE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string DAPCFPJOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double HIDNGFPHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool HJNNEEADOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int FKHJOKMOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> BIHMIKDJMFE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4A59B50", Offset = "0x4A58F50", VA = "0x184A59B50")]
	private static string LBGCFAIHGFJ(TKey LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A520", Offset = "0x4A59920", VA = "0x184A5A520")]
	public KIBLFINBBBG(string DAPCFPJOBCE = "F2", double HIDNGFPHGBL = double.MaxValue, bool HJNNEEADOBJ = false, int FKHJOKMOAJI = int.MaxValue, [Optional] ISet<string> BIHMIKDJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A440", Offset = "0x4A59840", VA = "0x184A5A440", Slot = "4")]
	public override Dictionary<string, string> OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4A59910", Offset = "0x4A58D10", VA = "0x184A59910")]
	private bool EHDBNKPAKKI(string LDHHFEGBKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4A59E00", Offset = "0x4A59200", VA = "0x184A59E00")]
	public Dictionary<string, string> OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE, ALNNMPMNKOO CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4A59B90", Offset = "0x4A58F90", VA = "0x184A59B90")]
	private string LJGKKHMKJAC(StringBuilder HAFFMBAJIGP, List<TKey> MMFDEJPCFBK, ALNNMPMNKOO CFAPLNKNFIH, bool IBGBHOPGLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4A599F0", Offset = "0x4A58DF0", VA = "0x184A599F0")]
	private static void KBMNLKIGCKH(StringBuilder CDIDDJHFGHL, string PONDKFDIPFO, bool HGGJFPHPCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IBHHMIJCLMJ<TKey> : OOPCMCOFIFC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OCBLPCAKDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FDMMDEFCIPJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static IBHHMIJCLMJ<TKey> IMFIEPMCPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] IGKNDLOIDAD;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4707FF0", Offset = "0x47073F0", VA = "0x184707FF0")]
	private IBHHMIJCLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4706F70", Offset = "0x4706370", VA = "0x184706F70", Slot = "5")]
	protected override string DFODICCKMEC(FGFDKLMANEA<TKey> ACNLNBKGHCE, FDMMDEFCIPJ CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4707DB0", Offset = "0x47071B0", VA = "0x184707DB0")]
	[CompilerGenerated]
	internal static string GNOAIFIIHIO(string HIGICKHMPJA, TKey LKMGECEEGEE, OCBLPCAKDCO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class KKGKLENEBCC : FGFDKLMANEA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AKMAPPACFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<KKGKLENEBCC, IBCMILIKEJG> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AKMAPPACFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x74285B0", Offset = "0x74279B0", VA = "0x1874285B0")]
		internal void GNFPAFPEHLE(FGFDKLMANEA<string> timer, IBCMILIKEJG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x742B670", Offset = "0x742AA70", VA = "0x18742B670")]
	public KKGKLENEBCC(IBCMILIKEJG DDKJAEALMGF, [Optional] string KDCJEBLDBJH, [Optional] int? NGLDOEKHAPH, [Optional] Stopwatch CFOIMBGPCMC, [Optional] Action<string, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA, [Optional] Action<string, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH, [Optional] Action<KKGKLENEBCC, IBCMILIKEJG> CODDEAMCOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x742B5B0", Offset = "0x742A9B0", VA = "0x18742B5B0")]
	private static Action<FGFDKLMANEA<string>, IBCMILIKEJG> GIBPACNAJBI(Action<KKGKLENEBCC, IBCMILIKEJG> IJCKFHFIADK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class EMNGBPGDJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HPAGDLBKLJI : EMNGBPGDJPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static EMNGBPGDJPK IMFIEPMCPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x742B460", Offset = "0x742A860", VA = "0x18742B460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float OOGBABHPKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xFDEC00", Offset = "0xFDE000", VA = "0x180FDEC00", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x742B560", Offset = "0x742A960", VA = "0x18742B560")]
		public HPAGDLBKLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static EMNGBPGDJPK CEEJKKOBOEJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static EMNGBPGDJPK MPDPNCAPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x742A120", Offset = "0x7429520", VA = "0x18742A120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float OOGBABHPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected EMNGBPGDJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BELJNJGLPJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EBHOPDBMNPK<T> : BELJNJGLPJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HNOCMNJEGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x33AC700", Offset = "0x33ABB00", VA = "0x1833AC700")]
	public static EBHOPDBMNPK<TResource> CFIKKDMOODK<TResource, TId>(this KDGGAAKPFMI<TId, TResource> HIDLDGNDFHN, TId KGHCKLKGJKM, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KFOFMPCPPED
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class LEDODBDBOAH<T> : IBMEPBNFOMN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NEEPBAPEEOL<T?> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4B57CD0", Offset = "0x4B570D0", VA = "0x184B57CD0")]
		public LEDODBDBOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class PMJFLODHFJD<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T DLLKKBMIKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? HEANOJFNKDG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x50AE620", Offset = "0x50ADA20", VA = "0x1850AE620")]
		public PMJFLODHFJD(T GINGHILKALC, Action<T>? BKAIFAJPEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x50AE3E0", Offset = "0x50AD7E0", VA = "0x1850AE3E0", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MGKFBHINOAO<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4D6FC70", Offset = "0x4D6F070", VA = "0x184D6FC70")]
		public MGKFBHINOAO(Exception JNJDMGFBFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class KCCEDCKHJMH<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct LLIIAAKFKFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<EBHOPDBMNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<EBHOPDBMNPK<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4B66C40", Offset = "0x4B66040", VA = "0x184B66C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4B67620", Offset = "0x4B66A20", VA = "0x184B67620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HHHLJJBIDMC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<EBHOPDBMNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<EBHOPDBMNPK<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4616170", Offset = "0x4615570", VA = "0x184616170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4616630", Offset = "0x4615A30", VA = "0x184616630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<EBHOPDBMNPK<T>> MPKKFNBDEJH;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D8D0", Offset = "0x4A3CCD0", VA = "0x184A3D8D0")]
		public KCCEDCKHJMH(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D5F0", Offset = "0x4A3C9F0", VA = "0x184A3D5F0", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D310", Offset = "0x4A3C710", VA = "0x184A3D310")]
		[AsyncStateMachine(typeof(KCCEDCKHJMH<>.LLIIAAKFKFO))]
		[CompilerGenerated]
		internal static Task<T> DKMNELHLIGM(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4A3D710", Offset = "0x4A3CB10", VA = "0x184A3D710")]
		[AsyncStateMachine(typeof(KCCEDCKHJMH<>.HHHLJJBIDMC))]
		[CompilerGenerated]
		internal static Task OCMKDAMLFMC(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class GPABADCAJND<TIn, TOut> : IBMEPBNFOMN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct KABJOGBJMLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4A34070", Offset = "0x4A33470", VA = "0x184A34070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x44FAAB0", Offset = "0x44F9EB0", VA = "0x1844FAAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly EBHOPDBMNPK<TIn> DEBKIEJDHCG;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NEEPBAPEEOL<TOut> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4562A80", Offset = "0x4561E80", VA = "0x184562A80")]
		public GPABADCAJND(EBHOPDBMNPK<TIn> GNGLLPGHGBH, Func<TIn, TOut> DJFFEOOKLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4562A30", Offset = "0x4561E30", VA = "0x184562A30", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4562860", Offset = "0x4561C60", VA = "0x184562860")]
		[AsyncStateMachine(typeof(GPABADCAJND<, >.KABJOGBJMLF))]
		[CompilerGenerated]
		internal static Task<TOut> FCNJNALGLIA(Task<TIn> JNEEHFAADNH, Func<TIn, TOut> DJFFEOOKLFI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x345FC30", Offset = "0x345F030", VA = "0x18345FC30")]
	public static EBHOPDBMNPK<T> DGEEMDAPOEK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x345FCB0", Offset = "0x345F0B0", VA = "0x18345FCB0")]
	public static EBHOPDBMNPK<T> KKNKEABJGIL<T>(T BIEIOPPGBOB, [Optional] Action<T>? BKAIFAJPEJC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
	public static EBHOPDBMNPK<T> DKFKIFIBHGC<T>(Exception JNJDMGFBFDL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
	public static EBHOPDBMNPK<T> KKJHHKOBDJE<T>(Task<EBHOPDBMNPK<T>> CBPINBDBDCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x31423A0", Offset = "0x31417A0", VA = "0x1831423A0")]
	public static EBHOPDBMNPK<TOut> KECLKMNFMIH<TOut, TIn>(EBHOPDBMNPK<TIn> ILIIBOPHLDK, Func<TIn, TOut> DJFFEOOKLFI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class IBMEPBNFOMN<T> : EBHOPDBMNPK<T>, BELJNJGLPJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string LKGNFHILCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly ANEFDAMIPJL JFLLGCNBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB39640", Offset = "0xB38A40", VA = "0x180B39640", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4708CF0", Offset = "0x47080F0", VA = "0x184708CF0")]
	public IBMEPBNFOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4708A30", Offset = "0x4707E30", VA = "0x184708A30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KOCGEEKMMPP();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IDPINFFBPGI<TTask, T> : IBMEPBNFOMN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ONOCMLCFMIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public ONOCMLCFMIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC9D0", Offset = "0x3CEBDD0", VA = "0x183CEC9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3CECC90", Offset = "0x3CEC090", VA = "0x183CECC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IDPINFFBPGI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ONOCMLCFMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4FCB960", Offset = "0x4FCAD60", VA = "0x184FCB960")]
		[AsyncStateMachine(typeof(IDPINFFBPGI<, >.ONOCMLCFMIF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NBACEKEDELD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> CBPINBDBDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource PMAMMIAHALH;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4718020", Offset = "0x4717420", VA = "0x184718020")]
	protected IDPINFFBPGI(TTask CBPINBDBDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4717FD0", Offset = "0x47173D0", VA = "0x184717FD0", Slot = "10")]
	protected override void KOCGEEKMMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DHKALHEMICK(TTask OJHAAGOGBNE);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DHGLNKNCHGP();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OCPDJKHGLJM<T> : IBMEPBNFOMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly KFDDALGMHJI<Task<T>> PKCAOLKNFIF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x454D850", Offset = "0x454CC50", VA = "0x18454D850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B760", Offset = "0x4F8AB60", VA = "0x184F8B760")]
	public OCPDJKHGLJM(KFDDALGMHJI<Task<T>> DOLJNDGNFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B740", Offset = "0x4F8AB40", VA = "0x184F8B740", Slot = "10")]
	protected override void KOCGEEKMMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FGNIBJIIOCP
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName BLDGHPMNHIK;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> OCKBBJILPGE;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x742A9C0", Offset = "0x7429DC0", VA = "0x18742A9C0")]
	public static int HADMDIIPMHF(this GJNJIONJAFL NKHIGAOONKE, IncrementalHash MGPEIJNPFNJ, byte[] HCBCPDBKAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x742A960", Offset = "0x7429D60", VA = "0x18742A960")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x742A320", Offset = "0x7429720", VA = "0x18742A320")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x742A630", Offset = "0x7429A30", VA = "0x18742A630")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE, IncrementalHash MGPEIJNPFNJ, byte[] HCBCPDBKAPC, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x742A290", Offset = "0x7429690", VA = "0x18742A290")]
	private static bool CGBFMBCFODB(byte[] PLFLANKIJFA, Span<byte> BPHENBJJBHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ELCMLCEPCPF
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7429FD0", Offset = "0x74293D0", VA = "0x187429FD0")]
	public static int NCJKMFKJGHP(HashAlgorithmName GAEIOCIOKGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7429D70", Offset = "0x7429170", VA = "0x187429D70")]
	public static int HADMDIIPMHF(this AKLCOKKIAMD OAPKHAIAMBK, byte[] PNDKHGKDAIK, IncrementalHash MGPEIJNPFNJ, byte[] LCJNMAGHHNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AKLCOKKIAMD
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MGPEIJNPFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GJNJIONJAFL : AKLCOKKIAMD
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] HEJPDEGNILB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] DHEHLHDCJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DCEFFPPLLBK
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool GODELGOMELD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> GNFNDMBOLGH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> GPJBHMDDMHI;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding OFHHKKKGNPH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> PCGAOEIGEIJ;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x31FA4A0", Offset = "0x31F98A0", VA = "0x1831FA4A0")]
	public static void BEKPJPKNACI<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] T MEFMJJOMDFE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x31FAA80", Offset = "0x31F9E80", VA = "0x1831FAA80")]
	public static void DKKGKNCPOAH<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] T OAPKHAIAMBK) where T : AKLCOKKIAMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x31FA560", Offset = "0x31F9960", VA = "0x1831FA560")]
	public static void DHCOHEALKOG<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] IList<T> OGPCJCBGIHN) where T : AKLCOKKIAMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74294A0", Offset = "0x74288A0", VA = "0x1874294A0")]
	private static bool HPLGCCOLHOJ([CanBeNull] AKLCOKKIAMD OAPKHAIAMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7428D30", Offset = "0x7428130", VA = "0x187428D30")]
	public static void EAKEKDJKLIE(this IncrementalHash MGPEIJNPFNJ, string? FPOEJCPHIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7428AA0", Offset = "0x7427EA0", VA = "0x187428AA0")]
	public static void ADGOMJMJIDL(this IncrementalHash MGPEIJNPFNJ, long PHHFPCMDPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7429810", Offset = "0x7428C10", VA = "0x187429810")]
	public static void PMPAIEBCBED(this IncrementalHash MGPEIJNPFNJ, int AGHNODDBJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7429640", Offset = "0x7428A40", VA = "0x187429640")]
	public static void PMJCBEBMOAN(this IncrementalHash MGPEIJNPFNJ, short PBMAMGNIEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7429530", Offset = "0x7428930", VA = "0x187429530")]
	public static void KIBGLEJDJOO(this IncrementalHash MGPEIJNPFNJ, byte CCGOIOPBFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x74292D0", Offset = "0x74286D0", VA = "0x1874292D0")]
	public static void GPAEMOOKJGB(this IncrementalHash MGPEIJNPFNJ, bool MOPEKJHNIBC, bool KKGJOBNFHII = false, bool KGEJADIAMJE = false, bool BBHKCNGKGMA = false, bool OPNKOGBKOMO = false, bool JIBLNMHJPNF = false, bool BDDDNDFIDLK = false, bool IGLFFLMPING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x31FAB10", Offset = "0x31F9F10", VA = "0x1831FAB10")]
	public static void MGKMAMBENIC<T>(this IncrementalHash MGPEIJNPFNJ, T JJFHAAOAACO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7428C70", Offset = "0x7428070", VA = "0x187428C70")]
	public static void APDGNDCHGIM(this IncrementalHash MGPEIJNPFNJ, float MDNLGMAHEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7429440", Offset = "0x7428840", VA = "0x187429440")]
	public static void HIMMAHIJOII(this IncrementalHash MGPEIJNPFNJ, ulong IBKDLCMDGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7428CD0", Offset = "0x74280D0", VA = "0x187428CD0")]
	public static void DAHMGAICLMH(this IncrementalHash MGPEIJNPFNJ, uint MKIKPGJFBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7429270", Offset = "0x7428670", VA = "0x187429270")]
	public static void GIJDDMOKMAN(this IncrementalHash MGPEIJNPFNJ, ushort CHHABJJMDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7429140", Offset = "0x7428540", VA = "0x187429140")]
	public static void EGFPDAHKAJO(this IncrementalHash MGPEIJNPFNJ, Vector3 DIKMDGBFJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCHPOHENKOJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7428780", Offset = "0x7427B80", VA = "0x187428780")]
	public BCHPOHENKOJ(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class HKGDPMOAOOK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void BHLAFMNIMNB(ushort BLAKIIPJCDE, ushort KEANEGKAODJ, ushort LAKMCLMLEJG, ushort DLAKCLNLEGB);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EINKAOFFLAO(ushort FJDKGIJPICA, ushort DKPMLPJJDJI);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void OAKIALGBHFD();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort ANOMIFEGDJP = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected HKGDPMOAOOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class DAKKCFAFGBP<T> : HKGDPMOAOOK where T : DAKKCFAFGBP<T>.IKNOCHLMCII
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface IKNOCHLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		EINKAOFFLAO LPIHLPMKEOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		EINKAOFFLAO NDJPEGCHKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		OAKIALGBHFD ICGOBMKAMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> ACDKCMGEPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private OAKIALGBHFD DHPLNLJEAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private OAKIALGBHFD DBPODFNNCKE;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HHHFMIOIODH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x949420", Offset = "0x948820", VA = "0x180949420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort LLGKIMJLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x628C1A0", Offset = "0x628B5A0", VA = "0x18628C1A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x628C1C0", Offset = "0x628B5C0", VA = "0x18628C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort CFAEIPNCHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x628C190", Offset = "0x628B590", VA = "0x18628C190")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x628C240", Offset = "0x628B640", VA = "0x18628C240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort KKHCPCCAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC486D0", Offset = "0xC47AD0", VA = "0x180C486D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xC487D0", Offset = "0xC47BD0", VA = "0x180C487D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort IDKCEILNBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x628C550", Offset = "0x628B950", VA = "0x18628C550")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x628BD00", Offset = "0x628B100", VA = "0x18628BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool MBLNODJLLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x155FFF0", Offset = "0x155F3F0", VA = "0x18155FFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool PIGIJMPFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD21DA0", Offset = "0xD211A0", VA = "0x180D21DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BHLAFMNIMNB FFGPJODNCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x628C300", Offset = "0x628B700", VA = "0x18628C300")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x628C0F0", Offset = "0x628B4F0", VA = "0x18628C0F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x628C040", Offset = "0x628B440", VA = "0x18628C040")]
	private T CDOJPIOLPBG(ushort OKFPOGHDMMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x628BD10", Offset = "0x628B110", VA = "0x18628BD10")]
	private T AKKIEFCECFP(ushort OKFPOGHDMMF, ushort EDFKFMIILHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x628C560", Offset = "0x628B960", VA = "0x18628C560")]
	protected T OHPOHIJGGBF(uint IHPDNFMIHPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x628C5D0", Offset = "0x628B9D0", VA = "0x18628C5D0")]
	protected DAKKCFAFGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x628C4B0", Offset = "0x628B8B0", VA = "0x18628C4B0")]
	public void LMCBACGBCHJ(ushort IFPMJFLCNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x628C4F0", Offset = "0x628B8F0", VA = "0x18628C4F0")]
	public void LMCBACGBCHJ(ushort IFPMJFLCNLG, ushort FHMLGPIJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x628C3A0", Offset = "0x628B7A0", VA = "0x18628C3A0", Slot = "4")]
	protected virtual void LMCBACGBCHJ(uint AGNMOKIJEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x628B4D0", Offset = "0x628A8D0", VA = "0x18628B4D0")]
	protected void ACHANLKDFBK(uint AGNMOKIJEOC, uint JOKBIJBKGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x628C250", Offset = "0x628B650", VA = "0x18628C250")]
	protected void IPFBACIIBJE(ushort OKFPOGHDMMF, ushort EDFKFMIILHD, T CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x628C1E0", Offset = "0x628B5E0", VA = "0x18628C1E0")]
	private void IJDMKHAFAIJ(uint IHPDNFMIHPP, T CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x628BDD0", Offset = "0x628B1D0", VA = "0x18628BDD0")]
	protected void BIHOJMHMDPD(float HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x628C1D0", Offset = "0x628B5D0", VA = "0x18628C1D0")]
	protected uint GJFMCBEBKLG(ushort OKFPOGHDMMF, ushort EDFKFMIILHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x628C5C0", Offset = "0x628B9C0", VA = "0x18628C5C0")]
	protected ushort PPIAEHPEEAI(uint MJPHEMOABKG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x628C1B0", Offset = "0x628B5B0", VA = "0x18628C1B0")]
	protected ushort EHNEMBOLLJF(uint MJPHEMOABKG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class AEJNPLOBCCL : DAKKCFAFGBP<AEJNPLOBCCL.LGCMODGLHIF>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class LGCMODGLHIF : IKNOCHLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public EINKAOFFLAO LPIHLPMKEOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public EINKAOFFLAO NDJPEGCHKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OAKIALGBHFD ICGOBMKAMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LGCMODGLHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7428440", Offset = "0x7427840", VA = "0x187428440")]
	public void KEMONPFHHHH(ushort CIADLKNJPHH, EINKAOFFLAO NCPALIAHJPF, EINKAOFFLAO JGHKOICLLNP, OAKIALGBHFD OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7428360", Offset = "0x7427760", VA = "0x187428360")]
	public void KEMONPFHHHH(ushort OKFPOGHDMMF, ushort EDFKFMIILHD, EINKAOFFLAO NCPALIAHJPF, EINKAOFFLAO JGHKOICLLNP, OAKIALGBHFD OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7428520", Offset = "0x7427920", VA = "0x187428520")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7428570", Offset = "0x7427970", VA = "0x187428570")]
	protected AEJNPLOBCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GGAINOJCJPJ : AEJNPLOBCCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A10", Offset = "0xAA5E10", VA = "0x180AA6A10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBA0880", Offset = "0xB9FC80", VA = "0x180BA0880")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x742AC70", Offset = "0x742A070", VA = "0x18742AC70")]
	public void HPHCPPKCEKM(ushort DHFNAGBHKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x742AC10", Offset = "0x742A010", VA = "0x18742AC10")]
	public void HPHCPPKCEKM(ushort DHFNAGBHKCH, ushort PPGMGOEEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7428570", Offset = "0x7427970", VA = "0x187428570")]
	public GGAINOJCJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class PICBGAGJNIG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class FKIKCCJFACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode JDCFMPOHCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode LDIAONMHHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NJANMHNOOBK ADMEOFCKKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<NJANMHNOOBK> CFBMIKMKDIH;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FKIKCCJFACP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct NJANMHNOOBK : IComparable<NJANMHNOOBK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int DKBNIPNLNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant JKOEKMKNDNK;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x141D850", Offset = "0x141CC50", VA = "0x18141D850")]
		public NJANMHNOOBK(int DKBNIPNLNJH, TClaimant JKOEKMKNDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ABF0", Offset = "0x4E79FF0", VA = "0x184E7ABF0")]
		public bool NMBIEENKKPK([In] NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ABE0", Offset = "0x4E79FE0", VA = "0x184E7ABE0")]
		public bool JJCMBCBBCMP([In] NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E7ABD0", Offset = "0x4E79FD0", VA = "0x184E7ABD0", Slot = "4")]
		public int CompareTo(NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E7AC50", Offset = "0x4E7A050", VA = "0x184E7AC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum LJIDILOJHOK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IIOPCEOKEGJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public PICBGAGJNIG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public IIOPCEOKEGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4721290", Offset = "0x4720690", VA = "0x184721290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4721470", Offset = "0x4720870", VA = "0x184721470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4721370", Offset = "0x4720770", VA = "0x184721370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x43C4250", Offset = "0x43C3650", VA = "0x1843C4250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly AJBFHMILPDB<FKIKCCJFACP> CGIHKOAOOJC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly AJBFHMILPDB<List<NJANMHNOOBK>> EAOIGOKOCOF;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int AMKCELBMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> LANFLIBPLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, FKIKCCJFACP> MOAGJPKCEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LJIDILOJHOK OALDHMLLKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KLKMJAGJCKK(TNode HPEELAFENFB);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DFBIJAGPPCN(TNode HPEELAFENFB, TClaimant NEHMBMIMNKH, TClaimant LLFJOPCPFHM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x50A3330", Offset = "0x50A2730", VA = "0x1850A3330")]
	public PICBGAGJNIG(LJIDILOJHOK OALDHMLLKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x50A2F20", Offset = "0x50A2320", VA = "0x1850A2F20")]
	public void PEJJKFLMNFP(TNode HPEELAFENFB, TNode DFDGPBFKIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x50A2FE0", Offset = "0x50A23E0", VA = "0x1850A2FE0")]
	public void PJFPMNEHKKB(TClaimant JKOEKMKNDNK, TNode HFAHJLIIBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x50A1FB0", Offset = "0x50A13B0", VA = "0x1850A1FB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x50A2A40", Offset = "0x50A1E40", VA = "0x1850A2A40")]
	private void HKMGMAFFMGP(TClaimant JKOEKMKNDNK, TNode IIOJHGIDFCI, TNode HFAHJLIIBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x50A2D30", Offset = "0x50A2130", VA = "0x1850A2D30")]
	private int NAPHNGLPKIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x50A21C0", Offset = "0x50A15C0", VA = "0x1850A21C0")]
	private void EJKHFKJJJJH(TClaimant JKOEKMKNDNK, TNode NFKKFDNNPKM, TNode LGNIHKABDBC, int KGNBOIDKMCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x50A2B10", Offset = "0x50A1F10", VA = "0x1850A2B10")]
	private void JCINDLAKIDB(NJANMHNOOBK BPCNLEDMJDA, FKIKCCJFACP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x50A1AA0", Offset = "0x50A0EA0", VA = "0x1850A1AA0")]
	private void BACMLELPLKC(TClaimant JKOEKMKNDNK, TNode NFKKFDNNPKM, TNode LGNIHKABDBC, int KGNBOIDKMCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x50A1D90", Offset = "0x50A1190", VA = "0x1850A1D90")]
	private void BLOBELNOFNA(NJANMHNOOBK BPCNLEDMJDA, TNode HPEELAFENFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x50A1830", Offset = "0x50A0C30", VA = "0x1850A1830")]
	private void ACGCNMJOKIA(NJANMHNOOBK BPCNLEDMJDA, FKIKCCJFACP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x50A2BE0", Offset = "0x50A1FE0", VA = "0x1850A2BE0")]
	private void MADANCLEBBP(FKIKCCJFACP NAKBEFGIDDJ, bool NLKOBGGEIMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x50A2510", Offset = "0x50A1910", VA = "0x1850A2510")]
	private void FPHPFPBOKHE(FKIKCCJFACP NAKBEFGIDDJ, TNode DFDGPBFKIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x50A1EC0", Offset = "0x50A12C0", VA = "0x1850A1EC0")]
	[IteratorStateMachine(typeof(PICBGAGJNIG<, >.IIOPCEOKEGJ))]
	private IEnumerable<TNode> DBFGGGNKHGG(TNode NFKKFDNNPKM, TNode LGNIHKABDBC, bool PKMICHNDCGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x50A1990", Offset = "0x50A0D90", VA = "0x1850A1990")]
	private FKIKCCJFACP ANNALDKIKAC(TNode HPEELAFENFB, TNode LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x50A2DA0", Offset = "0x50A21A0", VA = "0x1850A2DA0")]
	private FKIKCCJFACP NGIHEAHDIPB(TNode HPEELAFENFB, TNode LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x50A2880", Offset = "0x50A1C80", VA = "0x1850A2880")]
	private void HDEHJDBLMBN(FKIKCCJFACP NAKBEFGIDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PGPEJIODKCL<T> : IEnumerable<PGPEJIODKCL<T>.DCGOPFJHPKF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct DCGOPFJHPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T KBGCCIOIGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int EAHKFAJBNDN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class CIKENNBOJCK : IEnumerator<DCGOPFJHPKF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PGPEJIODKCL<T> JAGFBALGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x4030520", Offset = "0x402F920", VA = "0x184030520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public DCGOPFJHPKF FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x5A42A90", Offset = "0x5A41E90", VA = "0x185A42A90", Slot = "4")]
			get
			{
				return default(DCGOPFJHPKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5A42A50", Offset = "0x5A41E50", VA = "0x185A42A50")]
		public CIKENNBOJCK(PGPEJIODKCL<T> JAGFBALGAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5A429D0", Offset = "0x5A41DD0", VA = "0x185A429D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4089E50", Offset = "0x4089250", VA = "0x184089E50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xF5B430", Offset = "0xF5A830", VA = "0x180F5B430", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct POKEHHHPNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool HGOPPLOOAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T KBGCCIOIGBD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int PCLJNJBMHKB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OMFDHAFAIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private POKEHHHPNHH[] AJIIGDCKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DONFGMMIDKK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int FPHPIECAIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x98AE60", Offset = "0x98A260", VA = "0x18098AE60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x98A4B0", Offset = "0x9898B0", VA = "0x18098A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDFC0", Offset = "0x3CFD3C0", VA = "0x183CFDFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x50875C0", Offset = "0x50869C0", VA = "0x1850875C0")]
	public PGPEJIODKCL(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5086D70", Offset = "0x5086170", VA = "0x185086D70")]
	public PGPEJIODKCL(DCGOPFJHPKF[] HHKLNILIGOD, bool ACLMJHMHDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5086C10", Offset = "0x5086010", VA = "0x185086C10")]
	public int ONEFCEBIMHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5085EC0", Offset = "0x50852C0", VA = "0x185085EC0")]
	private int BGJEACAGHHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5086390", Offset = "0x5085790", VA = "0x185086390", Slot = "6")]
	protected virtual uint DPOHEDINKDL(uint MGPEIJNPFNJ, T KBGCCIOIGBD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5086B50", Offset = "0x5085F50", VA = "0x185086B50")]
	public bool NKNKPAELMGK(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5086A50", Offset = "0x5085E50", VA = "0x185086A50")]
	public int MJGCPNEONAH(T KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5086990", Offset = "0x5085D90", VA = "0x185086990")]
	public T KBDHOHCCAKN(int EAHKFAJBNDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x50868E0", Offset = "0x5085CE0", VA = "0x1850868E0")]
	public bool HFHDPLKFOBI(T KBGCCIOIGBD, bool LBHIBNMEMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5086680", Offset = "0x5085A80", VA = "0x185086680")]
	public bool HFHDPLKFOBI(T KBGCCIOIGBD, int EAHKFAJBNDN, bool LBHIBNMEMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x50862F0", Offset = "0x50856F0", VA = "0x1850862F0")]
	private int COENKJHHILC(int EKDINNHMJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5086CD0", Offset = "0x50860D0", VA = "0x185086CD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5086CD0", Offset = "0x50860D0", VA = "0x185086CD0", Slot = "4")]
	private IEnumerator<DCGOPFJHPKF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AJBFHMILPDB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> DFPGJPGNKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> FKPHPEFFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int FPCEEBAJBNG;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x4870BC0", Offset = "0x486FFC0", VA = "0x184870BC0")]
	public static AJBFHMILPDB<T> OEIHPKOBFOJ(int CCAKDDNOMFJ = 0, int FPCEEBAJBNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4870440", Offset = "0x486F840", VA = "0x184870440")]
	public static AJBFHMILPDB<T> CJOFJODOHHJ(int CCAKDDNOMFJ = 0, int FPCEEBAJBNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4870EC0", Offset = "0x48702C0", VA = "0x184870EC0")]
	public AJBFHMILPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4870CB0", Offset = "0x48700B0", VA = "0x184870CB0")]
	public AJBFHMILPDB(int CCAKDDNOMFJ, int FPCEEBAJBNG = int.MaxValue, bool COHEDEOGLPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x48709F0", Offset = "0x486FDF0", VA = "0x1848709F0")]
	public T OCHIEBOHGDJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4870360", Offset = "0x486F760", VA = "0x184870360")]
	public void BHDLIGCHPAN(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4870530", Offset = "0x486F930", VA = "0x184870530")]
	private void DBNKIGOEFLK(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x48709B0", Offset = "0x486FDB0", VA = "0x1848709B0")]
	private void MHHILEHAPLK(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4870630", Offset = "0x486FA30", VA = "0x184870630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x48707C0", Offset = "0x486FBC0", VA = "0x1848707C0")]
	private void KMPFLKCFILD(IEnumerable<T> BMKDAHEBDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CNFJEBJIPCB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> EIEEOCBNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T ENDNLINEDDD;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T DCEJFAOFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5C10640", Offset = "0x5C0FA40", VA = "0x185C10640")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x43D7C00", Offset = "0x43D7000", VA = "0x1843D7C00")]
	public bool OANKGFLJIAB(int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5C107E0", Offset = "0x5C0FBE0", VA = "0x185C107E0")]
	public T IPIHAOGMIFO(int LKLLMHOCFFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5C10C20", Offset = "0x5C10020", VA = "0x185C10C20")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5C10780", Offset = "0x5C0FB80", VA = "0x185C10780")]
	public bool GMJNAAAPBAP(int DKBNIPNLNJH, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x497AEF0", Offset = "0x497A2F0", VA = "0x18497AEF0")]
	public CNFJEBJIPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class BFMAEEMINOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct DCPOINHHOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MOEAGHOMEOM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<DCPOINHHOFI> ONOIJFJJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T MIEJMJEFGAG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDFC0", Offset = "0x3CFD3C0", VA = "0x183CFDFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x583BA80", Offset = "0x583AE80", VA = "0x18583BA80")]
	public bool HBIAGPPOPJF(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x583B8F0", Offset = "0x583ACF0", VA = "0x18583B8F0")]
	public void HBHDBABAKDP(T KBGCCIOIGBD, int DKBNIPNLNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x583C040", Offset = "0x583B440", VA = "0x18583C040")]
	public bool OCDDHDAHAOD(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x583BE70", Offset = "0x583B270", VA = "0x18583BE70")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x583BF10", Offset = "0x583B310", VA = "0x18583BF10")]
	public T NFIEKFOCNHN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x583B5F0", Offset = "0x583A9F0", VA = "0x18583B5F0")]
	protected void DEDAIFKIBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x583C3B0", Offset = "0x583B7B0", VA = "0x18583C3B0")]
	public BFMAEEMINOB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x742CA60", Offset = "0x742BE60", VA = "0x18742CA60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x742CD30", Offset = "0x742C130", VA = "0x18742CD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x742CC40", Offset = "0x742C040", VA = "0x18742CC40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x742C9B0", Offset = "0x742BDB0", VA = "0x18742C9B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x742CC80", Offset = "0x742C080", VA = "0x18742CC80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x742CB90", Offset = "0x742BF90", VA = "0x18742CB90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x742C920", Offset = "0x742BD20", VA = "0x18742C920")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x52807E0", Offset = "0x527FBE0", VA = "0x1852807E0", Slot = "4")]
		public virtual T MHOIHENGDGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LPKAAIKFLNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, HOFCLBIMKMP> MMCOFDGFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly AJBFHMILPDB<HOFCLBIMKMP> MEMHKMJDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool DLJLEONFJLL;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HOFCLBIMKMP AOPEGNLNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 EJLKDNEFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x13A8860", Offset = "0x13A7C60", VA = "0x1813A8860")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAEB120", Offset = "0xAEA520", VA = "0x180AEB120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 LOHJCFHFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB3C450", Offset = "0xB3B850", VA = "0x180B3C450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 DGJJMMMIMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x742C750", Offset = "0x742BB50", VA = "0x18742C750")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x94FCB0", Offset = "0x94F0B0", VA = "0x18094FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int CNFEKDNCACP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x94BDE0", Offset = "0x94B1E0", VA = "0x18094BDE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x94B9F0", Offset = "0x94ADF0", VA = "0x18094B9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x742C770", Offset = "0x742BB70", VA = "0x18742C770")]
	public LPKAAIKFLNI(Bounds FDAECNIODOF, Vector2[] DOIDPIABCIK, int CGIELBEDAIP, byte EKDINNHMJFC, float JNPIENLKIAC = 0f, [Optional] AJBFHMILPDB<HOFCLBIMKMP> MEMHKMJDHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x742BCC0", Offset = "0x742B0C0", VA = "0x18742BCC0")]
	public void GOIAGOGDGCF(Bounds FDAECNIODOF, Vector2[] DOIDPIABCIK, int CGIELBEDAIP, byte EKDINNHMJFC, float JNPIENLKIAC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x742BC00", Offset = "0x742B000", VA = "0x18742BC00")]
	public HOFCLBIMKMP FHPKHIFPBJH(byte EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x742C460", Offset = "0x742B860", VA = "0x18742C460")]
	public void OIELBLCHPLG(Vector3 NDADPNJPMFO, float PDMGANPIBAC, float FDEKCLGIEMI, List<byte> FCOHHBGCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x742B7C0", Offset = "0x742ABC0", VA = "0x18742B7C0")]
	public void CJOBFEBKEJP(HOFCLBIMKMP.KKPNHGHEJBM DHLKILMAGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x742C150", Offset = "0x742B550", VA = "0x18742C150")]
	public static int HNEMHCGCKBP(Vector2[] DOIDPIABCIK, int CGIELBEDAIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x742C230", Offset = "0x742B630", VA = "0x18742C230")]
	private HOFCLBIMKMP LHFNIEHFMGF(byte EAHKFAJBNDN, HOFCLBIMKMP.IGKMPIOBMHD FMLNOLNOIMH, HOFCLBIMKMP LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x742B7E0", Offset = "0x742ABE0", VA = "0x18742B7E0")]
	private void CNNPJDDEEOP(HOFCLBIMKMP LDIAONMHHPK, Vector2[] DOIDPIABCIK, int BDPBAFOOBGN, int OOEBPLCDDAC, int MNLODGJEKPF, int INJDBOOGMEN, float JNPIENLKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x742C530", Offset = "0x742B930", VA = "0x18742C530")]
	private void OMJNJIDJPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x742BBA0", Offset = "0x742AFA0", VA = "0x18742BBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x742BC60", Offset = "0x742B060", VA = "0x18742BC60", Slot = "1")]
	~LPKAAIKFLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HOFCLBIMKMP
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum IGKMPIOBMHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum KKPNHGHEJBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 IOLANELHHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 NGPEAGCEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 JLBFGLPGLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 KKLMMMJNMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public IGKMPIOBMHD OBJIKJPGLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HOFCLBIMKMP IACMILFIJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<HOFCLBIMKMP> LCGCPHCKLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool OLGCHCDLLFP;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x742B440", Offset = "0x742A840", VA = "0x18742B440")]
	public HOFCLBIMKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x742AFE0", Offset = "0x742A3E0", VA = "0x18742AFE0")]
	public void FCMEIMELBLA(HOFCLBIMKMP DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public void CJOBFEBKEJP(int DKHHCALAOBL, KKPNHGHEJBM DHLKILMAGOF, int IEDDIGKIIBL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x742B1E0", Offset = "0x742A5E0", VA = "0x18742B1E0")]
	public void OIELBLCHPLG(List<byte> FCOHHBGCDNA, Vector3 NDADPNJPMFO, float PDMGANPIBAC, float FDEKCLGIEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x742AFB0", Offset = "0x742A3B0", VA = "0x18742AFB0")]
	public bool CGONKALIBHI(Vector3 ILGJMEDBDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x742B1B0", Offset = "0x742A5B0", VA = "0x18742B1B0")]
	public bool JJDGOOHGPBK(Vector3 ILGJMEDBDKJ, float AHDGNGLLOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x742B120", Offset = "0x742A520", VA = "0x18742B120")]
	public void HPHCPPKCEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface BAMPFGJHMOM
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache HEKOHKIMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct BIOJDIAIJFO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> BHMKCPLLJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool CBEDACPCFBF;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x155CB70", Offset = "0x155BF70", VA = "0x18155CB70")]
			public BIOJDIAIJFO(List<Component> BHMKCPLLJPF, bool CBEDACPCFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x5843CA0", Offset = "0x58430A0", VA = "0x185843CA0")]
			public GDKKAEEJNLB<T> BNIMLGJMJBK()
			{
				return default(GDKKAEEJNLB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x5843D00", Offset = "0x5843100", VA = "0x185843D00", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x5843D00", Offset = "0x5843100", VA = "0x185843D00", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct GDKKAEEJNLB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> BHMKCPLLJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool CBEDACPCFBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int EAHKFAJBNDN;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T FJMLFGNPDDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x4481E60", Offset = "0x4481260", VA = "0x184481E60", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x4481DF0", Offset = "0x44811F0", VA = "0x184481DF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4481E30", Offset = "0x4481230", VA = "0x184481E30")]
			public GDKKAEEJNLB(List<Component> BHMKCPLLJPF, bool CBEDACPCFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x4481D30", Offset = "0x4481130", VA = "0x184481D30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x4481D40", Offset = "0x4481140", VA = "0x184481D40", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x407A8D0", Offset = "0x4079CD0", VA = "0x18407A8D0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x742E750", Offset = "0x742DB50", VA = "0x18742E750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x742E4B0", Offset = "0x742D8B0", VA = "0x18742E4B0")]
		private void HPHCPPKCEKM(GameObject CLIDGPLIAOB, bool MHOOEDPKADD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x742E620", Offset = "0x742DA20", VA = "0x18742E620")]
		public static void HPHCPPKCEKM(GameObject CLIDGPLIAOB, ToolHierarchyCache HIDLDGNDFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x742E6B0", Offset = "0x742DAB0", VA = "0x18742E6B0")]
		public void MKCIDOLIGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x374BC90", Offset = "0x374B090", VA = "0x18374BC90")]
		public void GFKOOFNGMHP<T>(Action<T> PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x374BED0", Offset = "0x374B2D0", VA = "0x18374BED0")]
		public T NHKPAFEOOFH<T>(bool CBEDACPCFBF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x374BBD0", Offset = "0x374AFD0", VA = "0x18374BBD0")]
		public BIOJDIAIJFO<T> GALDFEKGHJG<T>(bool CBEDACPCFBF = false) where T : class
		{
			return default(BIOJDIAIJFO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x742E070", Offset = "0x742D470", VA = "0x18742E070")]
		public List<Component> DNIMOIANDDG(Type BMIPLDLMPCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x742E3C0", Offset = "0x742D7C0", VA = "0x18742E3C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache IKAEODCKAIP, ToolHierarchyCache ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x742E440", Offset = "0x742D840", VA = "0x18742E440", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GMFKPONAANG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AACAJIHHNEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CCAKDDNOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GNBNOAIPBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> BHJLHIOPPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x454D850", Offset = "0x454CC50", VA = "0x18454D850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T ELELLAAAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x454D780", Offset = "0x454CB80", VA = "0x18454D780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T AMAEKDFPONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x454D5D0", Offset = "0x454C9D0", VA = "0x18454D5D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T DBMKPKCKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x454D400", Offset = "0x454C800", VA = "0x18454D400")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x454D900", Offset = "0x454CD00", VA = "0x18454D900")]
	public AACAJIHHNEA(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x454D230", Offset = "0x454C630", VA = "0x18454D230")]
	public void HBHDBABAKDP(T HLNLKLPFHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x454D570", Offset = "0x454C970", VA = "0x18454D570")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x454D480", Offset = "0x454C880", VA = "0x18454D480")]
	public void JPKAOKHGGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x454D8A0", Offset = "0x454CCA0", VA = "0x18454D8A0")]
	public void POLABFEHBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x454D0D0", Offset = "0x454C4D0", VA = "0x18454D0D0")]
	public void BCHAADBEKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x454D040", Offset = "0x454C440", VA = "0x18454D040")]
	public List<T> BBIMDPLNOCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GJKLJJDNPDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct FFBJODABCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MOEAGHOMEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T DEDOPNLMLPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, FFBJODABCDC> EIEEOCBNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> NIIKEIGHEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T ENDNLINEDDD;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T DCEJFAOFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xBC3070", Offset = "0xBC2470", VA = "0x180BC3070", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x44FE9C0", Offset = "0x44FDDC0", VA = "0x1844FE9C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4500ED0", Offset = "0x45002D0", VA = "0x184500ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object MDKHHJCKLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x44FECF0", Offset = "0x44FE0F0", VA = "0x1844FECF0")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, object LAAJFAFNFCN, int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4500F30", Offset = "0x4500330", VA = "0x184500F30")]
	public bool OANKGFLJIAB(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x44FF120", Offset = "0x44FE520", VA = "0x1844FF120")]
	public bool GMJNAAAPBAP(object LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x44FF560", Offset = "0x44FE960", VA = "0x1844FF560")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x44FF5B0", Offset = "0x44FE9B0", VA = "0x1844FF5B0")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4500FF0", Offset = "0x45003F0", VA = "0x184500FF0")]
	public GJKLJJDNPDD()
	{
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
