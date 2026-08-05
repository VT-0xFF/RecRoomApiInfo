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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E77C30", Offset = "0x6E76C30", VA = "0x186E77C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KPPPIAIECCO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A9B2A0", Offset = "0x1A9A2A0", VA = "0x181A9B2A0")]
	public KPPPIAIECCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HDONDABALHH, APHCFBPPFBL, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DFDCMIDOIMI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
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
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A260", Offset = "0x6E79260", VA = "0x186E7A260")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A220", Offset = "0x6E79220", VA = "0x186E7A220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A2A0", Offset = "0x6E792A0", VA = "0x186E7A2A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A450", Offset = "0x6E79450", VA = "0x186E7A450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A3C0", Offset = "0x6E793C0", VA = "0x186E7A3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB2DDE0", Offset = "0xB2CDE0", VA = "0x180B2DDE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A7610", Offset = "0x9A6610", VA = "0x1809A7610")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A1E0", Offset = "0x6E791E0", VA = "0x186E7A1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A330", Offset = "0x6E79330", VA = "0x186E7A330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E79C80", Offset = "0x6E78C80", VA = "0x186E79C80")]
	public void CopyBounds(SavedExtents DFABCHNPEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A130", Offset = "0x6E79130", VA = "0x186E7A130")]
	public void SetLocalSpaceBounds(Bounds JMBEBCNFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xF8AF40", Offset = "0xF89F40", VA = "0x180F8AF40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A120", Offset = "0x6E79120", VA = "0x186E7A120")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E79D70", Offset = "0x6E78D70", VA = "0x186E79D70")]
	private void HMMCHMDHKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E79F20", Offset = "0x6E78F20", VA = "0x186E79F20")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E79640", Offset = "0x6E78640", VA = "0x186E79640")]
	public static void CalculateLocalBoundsFor(GameObject IEELEEMHGEB, [Out] Bounds JMBEBCNFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E79CB0", Offset = "0x6E78CB0", VA = "0x186E79CB0")]
	private static void DMJLDLNAAIH(Bounds GMGEKOBCPAI, Color JGODMBGCENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E7A150", Offset = "0x6E79150", VA = "0x186E7A150")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13DA2D0", Offset = "0x13D92D0", VA = "0x1813DA2D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4DE5FF0", Offset = "0x4DE4FF0", VA = "0x184DE5FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	public virtual void KGLFIJMBEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
	[KPPPIAIECCO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5B00", Offset = "0x4DE4B00", VA = "0x184DE5B00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE4120", Offset = "0x4DE3120", VA = "0x184DE4120", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE5EE0", Offset = "0x4DE4EE0", VA = "0x184DE5EE0")]
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
	private sealed class MGJGAEPOAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MGJGAEPOAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x493F030", Offset = "0x493E030", VA = "0x18493F030")]
		internal int PPFOPOOAOCH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[KPPPIAIECCO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EAC0", Offset = "0x3C7DAC0", VA = "0x183C7EAC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EB20", Offset = "0x3C7DB20", VA = "0x183C7EB20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E990", Offset = "0x3C7D990", VA = "0x183C7E990", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MLAECOMLIEC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EA50", Offset = "0x3C7DA50", VA = "0x183C7EA50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E830", Offset = "0x3C7D830", VA = "0x183C7E830", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E4B0", Offset = "0x3C7D4B0", VA = "0x183C7E4B0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D820", Offset = "0x3C7C820", VA = "0x183C7D820", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D7F0", Offset = "0x3C7C7F0", VA = "0x183C7D7F0", Slot = "14")]
	protected virtual string HFHFJCJIGHF(TKeyVal BNPAILGIBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D680", Offset = "0x3C7C680", VA = "0x183C7D680", Slot = "4")]
	public bool ContainsKey(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E6A0", Offset = "0x3C7D6A0", VA = "0x183C7E6A0", Slot = "5")]
	public bool TryGetValue(TKey MLAECOMLIEC, [Out] TVal BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D6E0", Offset = "0x3C7C6E0", VA = "0x183C7D6E0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D6E0", Offset = "0x3C7C6E0", VA = "0x183C7D6E0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E700", Offset = "0x3C7D700", VA = "0x183C7E700")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x41629B0", Offset = "0x41619B0", VA = "0x1841629B0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[KPPPIAIECCO]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7AA0", Offset = "0x4DE6AA0", VA = "0x184DE7AA0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4DE7290", Offset = "0x4DE6290", VA = "0x184DE7290", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4DE67D0", Offset = "0x4DE57D0", VA = "0x184DE67D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NMLBHLPNIJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class IEDGMDOJJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float BHDLGEDHHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T DMNEEJMINJG;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IEDGMDOJJGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FDFPFDFLLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FDFPFDFLLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0F50", Offset = "0x3FEFF50", VA = "0x183FF0F50")]
		internal bool ILHBGFIAACL(IEDGMDOJJGI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float BNNBJFGICJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float LOIJPBNPEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<IEDGMDOJJGI> KMMIAMMLIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private OANBCOLHEBN<IEDGMDOJJGI> NEHBAOLNIMM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int GPFBJLOMNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x49F8D80", Offset = "0x49F7D80", VA = "0x1849F8D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49F95A0", Offset = "0x49F85A0", VA = "0x1849F95A0")]
	public NMLBHLPNIJG(float HJKBIGBLFEE, float KELOLDPCLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49F8730", Offset = "0x49F7730", VA = "0x1849F8730")]
	public bool BCKJMIFDDKM(float JEKIPNBIBLB, T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49F8E60", Offset = "0x49F7E60", VA = "0x1849F8E60")]
	public IEnumerable<T> HOPNBCNEJLN(float JEKIPNBIBLB, [Optional] float? GEILJFBAFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49F8B00", Offset = "0x49F7B00", VA = "0x1849F8B00")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49F8BC0", Offset = "0x49F7BC0", VA = "0x1849F8BC0")]
	private void GCPMBCDDJFD(float JEKIPNBIBLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OKFDLHJPBNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JMDDOBHBGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T DMNEEJMINJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float HHJLPJHDMLK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float JBLLBABEDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> PNMOFAEPBHC;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int CNEPMGMLJDM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JMDDOBHBGFB[] CHPMBGHOEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int NLACKHDBCPI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float IKOKDDDAJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD7C970", Offset = "0xD7B970", VA = "0x180D7C970")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xDAB900", Offset = "0xDAA900", VA = "0x180DAB900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E9D0", Offset = "0x4B1D9D0", VA = "0x184B1E9D0")]
	public OKFDLHJPBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E890", Offset = "0x4B1D890", VA = "0x184B1E890")]
	public OKFDLHJPBNP(int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E220", Offset = "0x4B1D220", VA = "0x184B1E220")]
	public void OPFOFHIGBEE(float JEKIPNBIBLB, T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D850", Offset = "0x4B1C850", VA = "0x184B1D850")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B1DCA0", Offset = "0x4B1CCA0", VA = "0x184B1DCA0")]
	public bool MAPPBJFILGP(float DFJEEPBJDPF, float HADDHGJHNIO, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E440", Offset = "0x4B1D440", VA = "0x184B1E440")]
	public bool PEDEBKADKHB(float DFJEEPBJDPF, float HADDHGJHNIO, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D940", Offset = "0x4B1C940", VA = "0x184B1D940")]
	public void FJGCCBHDEKG(float DFJEEPBJDPF, float HADDHGJHNIO, List<T> CNIEHBMANDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4B1DC70", Offset = "0x4B1CC70", VA = "0x184B1DC70")]
	private int FJHIDABOJGE(int GEHDPLAFIIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E1D0", Offset = "0x4B1D1D0", VA = "0x184B1E1D0")]
	private void MIHPMIJKBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MCBFIPLLNPJ();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DJBGAGHAMNK(T BJDKOHEGDOK, float JJJGJKKAJDC);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T MONHHFAAGIB(T LOPBCKBMJBH, T BMJGCJANGHI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HKFNJNFDDAP(T LOPBCKBMJBH, T BMJGCJANGHI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IPOEGOLPIFK : OKFDLHJPBNP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C5860", Offset = "0x8C4860", VA = "0x1808C5860", Slot = "4")]
	protected override Vector3 MCBFIPLLNPJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E77AC0", Offset = "0x6E76AC0", VA = "0x186E77AC0", Slot = "5")]
	protected override Vector3 DJBGAGHAMNK(Vector3 BJDKOHEGDOK, float JJJGJKKAJDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E77B80", Offset = "0x6E76B80", VA = "0x186E77B80", Slot = "6")]
	protected override Vector3 MONHHFAAGIB(Vector3 LOPBCKBMJBH, Vector3 BMJGCJANGHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E77B00", Offset = "0x6E76B00", VA = "0x186E77B00", Slot = "7")]
	protected override Vector3 HKFNJNFDDAP(Vector3 LOPBCKBMJBH, Vector3 BMJGCJANGHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E77BD0", Offset = "0x6E76BD0", VA = "0x186E77BD0")]
	public IPOEGOLPIFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PLGAFNHDMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x315BF70", Offset = "0x315AF70", VA = "0x18315BF70")]
	public static MDNNOAHFLIH<T1, T2> AIOPMLNOOEO<T1, T2>(T1 FEGDLLNLFLL, T2 BJEFMBPPKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x315C010", Offset = "0x315B010", VA = "0x18315C010")]
	public static HLKMHFOJHAM<T1, T2, T3> AIOPMLNOOEO<T1, T2, T3>(T1 FEGDLLNLFLL, T2 BJEFMBPPKLN, T3 OPKNPLBAGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x49A69A0", Offset = "0x49A59A0", VA = "0x1849A69A0")]
	internal static int OHLDGFFCKPK(int MJAGBENNEJF, int BIOFOKIBJLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x620B740", Offset = "0x620A740", VA = "0x18620B740")]
	internal static int OHLDGFFCKPK(int MJAGBENNEJF, int BIOFOKIBJLN, int IEJEGIHCOPA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MDNNOAHFLIH<T1, T2> : IComparable<MDNNOAHFLIH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 AECPJBILFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 CAEGLLFHDNE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4939B90", Offset = "0x4938B90", VA = "0x184939B90")]
	public MDNNOAHFLIH(T1 FEGDLLNLFLL, T2 BJEFMBPPKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4937C70", Offset = "0x4936C70", VA = "0x184937C70", Slot = "4")]
	public int CompareTo(MDNNOAHFLIH<T1, T2> DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4938510", Offset = "0x4937510", VA = "0x184938510", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4938D90", Offset = "0x4937D90", VA = "0x184938D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49394A0", Offset = "0x49384A0", VA = "0x1849394A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HLKMHFOJHAM<T1, T2, T3> : IComparable<HLKMHFOJHAM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 AECPJBILFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 CAEGLLFHDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 OJDBFDNLHEA;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4209000", Offset = "0x4208000", VA = "0x184209000")]
	public HLKMHFOJHAM(T1 FEGDLLNLFLL, T2 BJEFMBPPKLN, T3 OPKNPLBAGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42087C0", Offset = "0x42077C0", VA = "0x1842087C0", Slot = "4")]
	public int CompareTo(HLKMHFOJHAM<T1, T2, T3> DFABCHNPEEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4208A40", Offset = "0x4207A40", VA = "0x184208A40", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4208C00", Offset = "0x4207C00", VA = "0x184208C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4208E40", Offset = "0x4207E40", VA = "0x184208E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26432E0", Offset = "0x26422E0", VA = "0x1826432E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x26432D0", Offset = "0x26422D0", VA = "0x1826432D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float DPFHGPDEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x95FC40", Offset = "0x95EC40", VA = "0x18095FC40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x50445B0", Offset = "0x50435B0", VA = "0x1850445B0")]
	public T BFCDGEJDGOC(float JJJGJKKAJDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5044950", Offset = "0x5043950", VA = "0x185044950")]
	public T CIIHAJBMIHB(float JJJGJKKAJDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JOIKDLCGOHM(T LOPBCKBMJBH, T BMJGCJANGHI, float JJJGJKKAJDC);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E76D30", Offset = "0x6E75D30", VA = "0x186E76D30", Slot = "4")]
	protected override float JOIKDLCGOHM(float LOPBCKBMJBH, float BMJGCJANGHI, float JJJGJKKAJDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E76D70", Offset = "0x6E75D70", VA = "0x186E76D70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1253F00", Offset = "0x1252F00", VA = "0x181253F00", Slot = "4")]
	protected override Vector3 JOIKDLCGOHM(Vector3 LOPBCKBMJBH, Vector3 BMJGCJANGHI, float JJJGJKKAJDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B220", Offset = "0x6E7A220", VA = "0x186E7B220")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E767B0", Offset = "0x6E757B0", VA = "0x186E767B0", Slot = "4")]
	protected override Color JOIKDLCGOHM(Color LOPBCKBMJBH, Color BMJGCJANGHI, float JJJGJKKAJDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E76870", Offset = "0x6E75870", VA = "0x186E76870")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PLMAJDLHHGB : JPBJNKHOEPB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E790C0", Offset = "0x6E780C0", VA = "0x186E790C0")]
	public PLMAJDLHHGB(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E79050", Offset = "0x6E78050", VA = "0x186E79050", Slot = "6")]
	protected override uint IPNCEIPHPMK(uint DFDCMIDOIMI, string BJDKOHEGDOK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BBLECHCNCAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable LONLOOPDCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public BBLECHCNCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DPJENNCALOM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HJLHGOEIGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int HDLGHADJMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int LDAIOEMDCNN;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x437C0E0", Offset = "0x437B0E0", VA = "0x18437C0E0")]
	private DPJENNCALOM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BNBMGAGIHCG, int BCIAFKAEHGJ, int ODCLBFGKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1A00", Offset = "0x5DD0A00", VA = "0x185DD1A00")]
	public static DPJENNCALOM<T> EJLELCHFLID()
	{
		return default(DPJENNCALOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD29D0", Offset = "0x5DD19D0", VA = "0x185DD29D0")]
	public (int, int, Task<T>) FLALLNPLDAL(int EJNEHCOECHP, [Optional] CancellationToken CLIKNEKJHEI, double OPFDDHFIGGD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3A60", Offset = "0x5DD2A60", VA = "0x185DD3A60")]
	public void HJMAIMLJNFG(int EJNEHCOECHP, int ODCLBFGKODG, [In] T POCKBMKNJHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EJHFPJJNGPM
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E769F0", Offset = "0x6E759F0", VA = "0x186E769F0")]
	public static DPJENNCALOM<MKHCENILMPB> EJLELCHFLID()
	{
		return default(DPJENNCALOM<MKHCENILMPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E76A40", Offset = "0x6E75A40", VA = "0x186E76A40")]
	public static void HJMAIMLJNFG([In] this DPJENNCALOM<MKHCENILMPB> GFJPFDOHONG, int EJNEHCOECHP, int ODCLBFGKODG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class LIODPKEEOBA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> JKEHGCCMDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> GLADPEIKIMM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x395A3E0", Offset = "0x39593E0", VA = "0x18395A3E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool AGBMIOANOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> KKDDLFINFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x45759F0", Offset = "0x45749F0", VA = "0x1845759F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> EHCBJAEHPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x41F2790", Offset = "0x41F1790", VA = "0x1841F2790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4755DF0", Offset = "0x4754DF0", VA = "0x184755DF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4755E60", Offset = "0x4754E60", VA = "0x184755E60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4755860", Offset = "0x4754860", VA = "0x184755860")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47550B0", Offset = "0x47540B0", VA = "0x1847550B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4755BB0", Offset = "0x4754BB0", VA = "0x184755BB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4755020", Offset = "0x4754020", VA = "0x184755020", Slot = "9")]
	public void Add(TKey MLAECOMLIEC, TVal BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4754FD0", Offset = "0x4753FD0", VA = "0x184754FD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4575990", Offset = "0x4574990", VA = "0x184575990", Slot = "8")]
	public bool ContainsKey(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x47551A0", Offset = "0x47541A0", VA = "0x1847551A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4755AA0", Offset = "0x4754AA0", VA = "0x184755AA0", Slot = "10")]
	public bool Remove(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4755B20", Offset = "0x4754B20", VA = "0x184755B20", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4755C00", Offset = "0x4754C00", VA = "0x184755C00", Slot = "11")]
	public bool TryGetValue(TKey MLAECOMLIEC, [Out] TVal BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4755270", Offset = "0x4754270", VA = "0x184755270", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x47551E0", Offset = "0x47541E0", VA = "0x1847551E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHPMBGHOEJI, int MJFNOLHAPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x47554F0", Offset = "0x47544F0", VA = "0x1847554F0")]
	public bool JIBJJFGCKGK(TVal MLAECOMLIEC, [Out] TKey BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4755310", Offset = "0x4754310", VA = "0x184755310")]
	private void JCKKKNNNGBD(TKey MLAECOMLIEC, TVal ADMAMDKLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x47558C0", Offset = "0x47548C0", VA = "0x1847558C0")]
	private void NBADKEIIIIN(TKey MLAECOMLIEC, TVal ADMAMDKLPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x47555B0", Offset = "0x47545B0", VA = "0x1847555B0")]
	private bool LMLCIHOFKPN(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4755C60", Offset = "0x4754C60", VA = "0x184755C60")]
	public LIODPKEEOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ECMMEPABPBD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ECMMEPABPBD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3CC9CF0", Offset = "0x3CC8CF0", VA = "0x183CC9CF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3CDA280", Offset = "0x3CD9280", VA = "0x183CDA280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB100", Offset = "0x3CDA100", VA = "0x183CDB100")]
		public Enumerator(ECMMEPABPBD<T> CNIEHBMANDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD74B0", Offset = "0x3CD64B0", VA = "0x183CD74B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8D10", Offset = "0x3CD7D10", VA = "0x183CD8D10", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD72C0", Offset = "0x3CD62C0", VA = "0x183CD72C0")]
		private void BOFHKADJMEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] HOHLANLKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int KECPKLHBJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int GDFGKEPOHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int FNBFBBNHKCM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C45F40", Offset = "0x3C44F40", VA = "0x183C45F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C463B0", Offset = "0x3C453B0", VA = "0x183C463B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C461C0", Offset = "0x3C451C0", VA = "0x183C461C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C47870", Offset = "0x3C46870", VA = "0x183C47870")]
	public ECMMEPABPBD(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C46F30", Offset = "0x3C45F30", VA = "0x183C46F30")]
	public void OPFOFHIGBEE(T JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C45CE0", Offset = "0x3C44CE0", VA = "0x183C45CE0")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C45E30", Offset = "0x3C44E30", VA = "0x183C45E30")]
	public void GCBLPKNNGGM(int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C46AB0", Offset = "0x3C45AB0", VA = "0x183C46AB0")]
	public void NNFEGMMHAAH(T[] CHPMBGHOEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C45D70", Offset = "0x3C44D70", VA = "0x183C45D70")]
	public Enumerator EMFBOAAPBLH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C477B0", Offset = "0x3C467B0", VA = "0x183C477B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C477B0", Offset = "0x3C467B0", VA = "0x183C477B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C457E0", Offset = "0x3C447E0", VA = "0x183C457E0")]
	private int BBPDMEKOPOO(int KHAIDMGPIED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C45F10", Offset = "0x3C44F10", VA = "0x183C45F10")]
	private int JIBOPOGONJP(int KHAIDMGPIED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GEBPGCJFELG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> DBKGHKJNCNL(TRequest ONMEAHDGGOB, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum ELNHDLFNJGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class IINIEJFONNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float EELGEHMFIMH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan IBFLABGECIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int CNOAEIAOKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public ELNHDLFNJGM DLFFNOGODEJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly IINIEJFONNB LONMIMAJOAB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float PLHKGNNFAAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x435DAC0", Offset = "0x435CAC0", VA = "0x18435DAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan ADBIAAMGHLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x435DC80", Offset = "0x435CC80", VA = "0x18435DC80")]
		public IINIEJFONNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct BJHLOCOGIDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest ONMEAHDGGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken CLIKNEKJHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> GOBKHGGOFJJ;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5352790", Offset = "0x5351790", VA = "0x185352790")]
		public BJHLOCOGIDH(TRequest ONMEAHDGGOB, TaskCompletionSource<TResult> GOBKHGGOFJJ, CancellationToken CLIKNEKJHEI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct LFJBHPONCHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GEBPGCJFELG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4745970", Offset = "0x4744970", VA = "0x184745970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4745D80", Offset = "0x4744D80", VA = "0x184745D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct MMFGNOEEDFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GEBPGCJFELG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private BJHLOCOGIDH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49659C0", Offset = "0x49649C0", VA = "0x1849659C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4966030", Offset = "0x4965030", VA = "0x184966030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource JGGLFKABEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<BJHLOCOGIDH> BPKKNPEAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IINIEJFONNB HIKBPLMDKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly DBKGHKJNCNL ABPCHIHLNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task LIDFCBOFLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int LLONHFOMFJI;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x415AEB0", Offset = "0x4159EB0", VA = "0x18415AEB0")]
	public GEBPGCJFELG(DBKGHKJNCNL ABPCHIHLNPD, [Optional] IINIEJFONNB HIKBPLMDKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4159F20", Offset = "0x4158F20", VA = "0x184159F20")]
	public Task<TResult> IKGJEFDKKJO(TRequest ONMEAHDGGOB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4159550", Offset = "0x4158550", VA = "0x184159550")]
	private void FEJGGDAANHE(BJHLOCOGIDH JHCKMPFHLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x415AB00", Offset = "0x4159B00", VA = "0x18415AB00")]
	[AsyncStateMachine(typeof(GEBPGCJFELG<, >.LFJBHPONCHC))]
	private Task PIAMGFCBOJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4159620", Offset = "0x4158620", VA = "0x184159620")]
	private BJHLOCOGIDH FJJIIMLHDEA()
	{
		return default(BJHLOCOGIDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x415ADC0", Offset = "0x4159DC0", VA = "0x18415ADC0")]
	[AsyncStateMachine(typeof(GEBPGCJFELG<, >.MMFGNOEEDFN))]
	private Task POGNKCGEEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x415A740", Offset = "0x4159740", VA = "0x18415A740")]
	private void OEELDDBPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4159350", Offset = "0x4158350", VA = "0x184159350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class CFOAJGDPHJG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> AKKGGCHEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> DLAALNNAFHL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x395A3E0", Offset = "0x39593E0", VA = "0x18395A3E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AGBMIOANOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E76930", Offset = "0x2E75930", VA = "0x182E76930", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5714CF0", Offset = "0x5713CF0", VA = "0x185714CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x403B420", Offset = "0x403A420", VA = "0x18403B420", Slot = "11")]
	public void Add(T KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5714500", Offset = "0x5713500", VA = "0x185714500")]
	public bool OFBEPAEKHBO(T KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x57148D0", Offset = "0x57138D0", VA = "0x1857148D0", Slot = "15")]
	public bool Remove(T KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x400D970", Offset = "0x400C970", VA = "0x18400D970", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4052090", Offset = "0x4051090", VA = "0x184052090", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5713FE0", Offset = "0x5712FE0", VA = "0x185713FE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5714090", Offset = "0x5713090", VA = "0x185714090", Slot = "13")]
	public bool Contains(T KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x57140F0", Offset = "0x57130F0", VA = "0x1857140F0", Slot = "14")]
	public void CopyTo(T[] CHPMBGHOEJI, int MJFNOLHAPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x46EDB50", Offset = "0x46ECB50", VA = "0x1846EDB50", Slot = "6")]
	public int IndexOf(T KBDJJFPFPLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57142A0", Offset = "0x57132A0", VA = "0x1857142A0", Slot = "7")]
	public void Insert(int KHAIDMGPIED, T KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5714610", Offset = "0x5713610", VA = "0x185714610", Slot = "8")]
	public void RemoveAt(int KHAIDMGPIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5714A70", Offset = "0x5713A70", VA = "0x185714A70")]
	public CFOAJGDPHJG()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x24ECA00", Offset = "0x24EBA00", VA = "0x1824ECA00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A7F0", Offset = "0x6E797F0", VA = "0x186E7A7F0")]
		public SerializedGuid([In] Guid EEKOILIMLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A570", Offset = "0x6E79570", VA = "0x186E7A570")]
		public static SerializedGuid DNEHCAGBCKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A780", Offset = "0x6E79780", VA = "0x186E7A780")]
		public static SerializedGuid PHPKPAPCDAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A510", Offset = "0x6E79510", VA = "0x186E7A510")]
		public bool DCLLIFLPMLP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A750", Offset = "0x6E79750", VA = "0x186E7A750", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A6D0", Offset = "0x6E796D0", VA = "0x186E7A6D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A5F0", Offset = "0x6E795F0", VA = "0x186E7A5F0", Slot = "7")]
		public bool Equals(SerializedGuid DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A630", Offset = "0x6E79630", VA = "0x186E7A630", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A6C0", Offset = "0x6E796C0", VA = "0x186E7A6C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A4E0", Offset = "0x6E794E0", VA = "0x186E7A4E0", Slot = "6")]
		public int CompareTo(SerializedGuid DFABCHNPEEM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GCIPEOIOBGP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type CKLIJDEBHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string CNGMHKLMCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool PDNFLDNEBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool AGMJEOCNALM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E76DB0", Offset = "0x6E75DB0", VA = "0x186E76DB0")]
	public GCIPEOIOBGP(Type MDGMLAEGKPC, string PGHJIFNKEFJ, bool FEOLKOPLKKJ = false, bool PFCGPHKNCDN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NPOAFBCOAIB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct EFDBIOKGMFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long JJJEHGJPLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long INDFCAPBEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int JJFDHLDHIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int NJBLEBAPDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool KMDOCJGDJKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string GNAEJJMANHG;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B9D0", Offset = "0x3C4A9D0", VA = "0x183C4B9D0")]
		public EFDBIOKGMFA(long JJJEHGJPLCP, int JJFDHLDHIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B9A0", Offset = "0x3C4A9A0", VA = "0x183C4B9A0")]
		public EFDBIOKGMFA(long JJJEHGJPLCP, long INDFCAPBEME, int JJFDHLDHIMC, int NJBLEBAPDIA, bool KMDOCJGDJKB, string GNAEJJMANHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B8F0", Offset = "0x3C4A8F0", VA = "0x183C4B8F0")]
		public int JGJGGKNGBLC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B8D0", Offset = "0x3C4A8D0", VA = "0x183C4B8D0")]
		public int ELHLIAKPBOF(int HFNPHCJKNKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B940", Offset = "0x3C4A940", VA = "0x183C4B940")]
		public double KFHJGAAECFA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B830", Offset = "0x3C4A830", VA = "0x183C4B830")]
		public EFDBIOKGMFA DPJIGEJIILG(long INDFCAPBEME, int NJBLEBAPDIA)
		{
			return default(EFDBIOKGMFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class HFMLKGGDOCE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct PDFMDOOFGOC<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public HFMLKGGDOCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<HFMLKGGDOCE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private HFMLKGGDOCE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4BD31B0", Offset = "0x4BD21B0", VA = "0x184BD31B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x400D1C0", Offset = "0x400C1C0", VA = "0x18400D1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey AEDGBICBIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NPOAFBCOAIB<TKey> FCPMHEOCJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CDBONJBDMGH IKKEHAGICFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<HFMLKGGDOCE> LPGMOCBPKDN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string FMMFKEPKDFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x41EF720", Offset = "0x41EE720", VA = "0x1841EF720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<HFMLKGGDOCE> PNAPELGBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x41EF6E0", Offset = "0x41EE6E0", VA = "0x1841EF6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EFDBIOKGMFA MGDMMLENCDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x41EF7B0", Offset = "0x41EE7B0", VA = "0x1841EF7B0")]
			[CompilerGenerated]
			get
			{
				return default(EFDBIOKGMFA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x41EF780", Offset = "0x41EE780", VA = "0x1841EF780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x41EF990", Offset = "0x41EE990", VA = "0x1841EF990")]
		internal HFMLKGGDOCE(NPOAFBCOAIB<TKey> FCPMHEOCJMB, TKey MLAECOMLIEC, CDBONJBDMGH IKKEHAGICFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x41EF7D0", Offset = "0x41EE7D0", VA = "0x1841EF7D0")]
		public HFMLKGGDOCE OKHKJKJDKJA(TKey MLAECOMLIEC, [Optional] CDBONJBDMGH? PJKDGEADOAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x326F8B0", Offset = "0x326E8B0", VA = "0x18326F8B0")]
		[AsyncStateMachine(typeof(PDFMDOOFGOC<>))]
		public Task<T> BPLNEOFEPIE<T>(TKey MLAECOMLIEC, Func<HFMLKGGDOCE, Task<T>> LILCNNNEFGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x41EF480", Offset = "0x41EE480", VA = "0x1841EF480", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PBDNDKJDDPF : IEnumerable<(TKey, List<TKey>, EFDBIOKGMFA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EFDBIOKGMFA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, EFDBIOKGMFA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NPOAFBCOAIB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, EFDBIOKGMFA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, EFDBIOKGMFA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x24ED2F0", Offset = "0x24EC2F0", VA = "0x1824ED2F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EFDBIOKGMFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4BCF750", Offset = "0x4BCE750", VA = "0x184BCF750", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x24ED3E0", Offset = "0x24EC3E0", VA = "0x1824ED3E0")]
		[DebuggerHidden]
		public PBDNDKJDDPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3DF29B0", Offset = "0x3DF19B0", VA = "0x183DF29B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF270", Offset = "0x4BCE270", VA = "0x184BCF270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF220", Offset = "0x4BCE220", VA = "0x184BCF220")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF700", Offset = "0x4BCE700", VA = "0x184BCF700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF620", Offset = "0x4BCE620", VA = "0x184BCF620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EFDBIOKGMFA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F52660", Offset = "0x3F51660", VA = "0x183F52660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class MDOHCGKBPJN : IEnumerable<(TKey, List<TKey>, EFDBIOKGMFA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EFDBIOKGMFA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, EFDBIOKGMFA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HFMLKGGDOCE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HFMLKGGDOCE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NPOAFBCOAIB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<HFMLKGGDOCE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, EFDBIOKGMFA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, EFDBIOKGMFA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x24ED2F0", Offset = "0x24EC2F0", VA = "0x1824ED2F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EFDBIOKGMFA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x493A600", Offset = "0x4939600", VA = "0x18493A600", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x24ED3E0", Offset = "0x24EC3E0", VA = "0x1824ED3E0")]
		[DebuggerHidden]
		public MDOHCGKBPJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x493A660", Offset = "0x4939660", VA = "0x18493A660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4939C90", Offset = "0x4938C90", VA = "0x184939C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4939C30", Offset = "0x4938C30", VA = "0x184939C30")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4939BD0", Offset = "0x4938BD0", VA = "0x184939BD0")]
		private void AFDHGAJFOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x493A5B0", Offset = "0x49395B0", VA = "0x18493A5B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x493A470", Offset = "0x4939470", VA = "0x18493A470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EFDBIOKGMFA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x493A570", Offset = "0x4939570", VA = "0x18493A570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, EFDBIOKGMFA, CDBONJBDMGH> OOMACAPMJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, EFDBIOKGMFA, CDBONJBDMGH> KPPGIDMMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<NPOAFBCOAIB<TKey>, CDBONJBDMGH> CDBCFMOBJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HFMLKGGDOCE AHLILBJHHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool GNHIBNEGODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MIOGHIHKLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch FJOMIAFFMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int ALFNOIPNOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string FCDAHCHBEDE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HFMLKGGDOCE JHENLCGKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string FMMFKEPKDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4A046D0", Offset = "0x4A036D0", VA = "0x184A046D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A047B0", Offset = "0x4A037B0", VA = "0x184A047B0")]
	public NPOAFBCOAIB(TKey CELPEICPEJP, CDBONJBDMGH IKKEHAGICFD, [Optional] int? JJFDHLDHIMC, [Optional][CanBeNull] Stopwatch FJOMIAFFMAH, [Optional] Action<TKey, EFDBIOKGMFA, CDBONJBDMGH> OOMACAPMJCH, [Optional] Action<TKey, EFDBIOKGMFA, CDBONJBDMGH> KPPGIDMMHHO, [Optional] Action<NPOAFBCOAIB<TKey>, CDBONJBDMGH> CDBCFMOBJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4A04450", Offset = "0x4A03450", VA = "0x184A04450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A04530", Offset = "0x4A03530", VA = "0x184A04530")]
	[IteratorStateMachine(typeof(NPOAFBCOAIB<>.PBDNDKJDDPF))]
	public IEnumerable<(TKey, List<TKey>, EFDBIOKGMFA)> HGKLGHMKAPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A045E0", Offset = "0x4A035E0", VA = "0x184A045E0")]
	[IteratorStateMachine(typeof(NPOAFBCOAIB<>.MDOHCGKBPJN))]
	private IEnumerable<(TKey, List<TKey>, EFDBIOKGMFA)> HGKLGHMKAPJ(List<TKey> MBDMHLKHKIH, HFMLKGGDOCE ONBOJLEJFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A04730", Offset = "0x4A03730", VA = "0x184A04730")]
	private (long, int) KNINNJJOJBH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CBCPMHHKFGD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HBDEGIGLJBL(NPOAFBCOAIB<TKey> FCPMHEOCJMB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected CBCPMHHKFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class ANKFHHOLAIN<TKey> : CBCPMHHKFGD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string BDHNJGBNPAA(TKey MLAECOMLIEC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x43E0500", Offset = "0x43DF500", VA = "0x1843E0500")]
	private static string OAJNFEKKAFH(TKey MLAECOMLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x43E0410", Offset = "0x43DF410", VA = "0x1843E0410", Slot = "4")]
	public override string HBDEGIGLJBL(NPOAFBCOAIB<TKey> FCPMHEOCJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x43E02B0", Offset = "0x43DF2B0", VA = "0x1843E02B0")]
	public string HBDEGIGLJBL(NPOAFBCOAIB<TKey> FCPMHEOCJMB, [NotNull] BDHNJGBNPAA OBENMCBMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ECJGKFBAGAM(NPOAFBCOAIB<TKey> FCPMHEOCJMB, [NotNull] BDHNJGBNPAA OBENMCBMMCC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x42E46C0", Offset = "0x42E36C0", VA = "0x1842E46C0")]
	protected ANKFHHOLAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LDDAKAPEOHM<TKey> : CBCPMHHKFGD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string LFHCCJEMMPA(TKey MLAECOMLIEC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string EDOFNICDBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double ILGPBNDGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool ICLDPBFBNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int OFDPGKHBKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> ACONPDNPABI;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x473E070", Offset = "0x473D070", VA = "0x18473E070")]
	private static string OAJNFEKKAFH(TKey MLAECOMLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x473E0B0", Offset = "0x473D0B0", VA = "0x18473E0B0")]
	public LDDAKAPEOHM(string EDOFNICDBFO = "F2", double ILGPBNDGOEE = double.MaxValue, bool ICLDPBFBNDD = false, int OFDPGKHBKEN = int.MaxValue, [Optional] ISet<string> ACONPDNPABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x473DB30", Offset = "0x473CB30", VA = "0x18473DB30", Slot = "4")]
	public override Dictionary<string, string> HBDEGIGLJBL(NPOAFBCOAIB<TKey> FCPMHEOCJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x473E000", Offset = "0x473D000", VA = "0x18473E000")]
	private bool KOJDMMEEBKP(string JPCNDGMKCBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x473D4E0", Offset = "0x473C4E0", VA = "0x18473D4E0")]
	public Dictionary<string, string> HBDEGIGLJBL(NPOAFBCOAIB<TKey> FCPMHEOCJMB, LFHCCJEMMPA OBENMCBMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x473DC20", Offset = "0x473CC20", VA = "0x18473DC20")]
	private string HOMHHFDNJIL(StringBuilder KCBIANIKENA, List<TKey> FJLCPKLCFOE, LFHCCJEMMPA OBENMCBMMCC, bool KABNMCKMKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x473DEA0", Offset = "0x473CEA0", VA = "0x18473DEA0")]
	private static void KJHOIOLDONI(StringBuilder EICBENJHGLJ, string ILAKKEDFBHA, bool MNEFCFBBPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GENJEKOGLCK<TKey> : ANKFHHOLAIN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FMJLIDBJHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BDHNJGBNPAA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static GENJEKOGLCK<TKey> LONLOOPDCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] AAJHIFCADPP;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x41610D0", Offset = "0x41600D0", VA = "0x1841610D0")]
	private GENJEKOGLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4160040", Offset = "0x415F040", VA = "0x184160040", Slot = "5")]
	protected override string ECJGKFBAGAM(NPOAFBCOAIB<TKey> FCPMHEOCJMB, BDHNJGBNPAA OBENMCBMMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4160E70", Offset = "0x415FE70", VA = "0x184160E70")]
	[CompilerGenerated]
	internal static string OOJOADGOMEP(string BNOLABCCKCC, TKey MLAECOMLIEC, FMJLIDBJHOB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class FLCBPMDCCAH : NPOAFBCOAIB<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class OPCIBJGLGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<FLCBPMDCCAH, CDBONJBDMGH> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OPCIBJGLGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6E78FC0", Offset = "0x6E77FC0", VA = "0x186E78FC0")]
		internal void BMAIPMJNBEL(NPOAFBCOAIB<string> timer, CDBONJBDMGH log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E76BE0", Offset = "0x6E75BE0", VA = "0x186E76BE0")]
	public FLCBPMDCCAH(CDBONJBDMGH IKKEHAGICFD, [Optional] string AEPBMBJKDCK, [Optional] int? JJFDHLDHIMC, [Optional] Stopwatch FJOMIAFFMAH, [Optional] Action<string, EFDBIOKGMFA, CDBONJBDMGH> OOMACAPMJCH, [Optional] Action<string, EFDBIOKGMFA, CDBONJBDMGH> KPPGIDMMHHO, [Optional] Action<FLCBPMDCCAH, CDBONJBDMGH> CDBCFMOBJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E76B20", Offset = "0x6E75B20", VA = "0x186E76B20")]
	private static Action<NPOAFBCOAIB<string>, CDBONJBDMGH> PCGKFAKJDJN(Action<FLCBPMDCCAH, CDBONJBDMGH> BLNJHEMNIGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class OBLKNCNEFLP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class ECBIHKACAMM : OBLKNCNEFLP
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static OBLKNCNEFLP LONLOOPDCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6E768B0", Offset = "0x6E758B0", VA = "0x186E768B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float KAFNJMECABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xD73670", Offset = "0xD72670", VA = "0x180D73670", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6E769A0", Offset = "0x6E759A0", VA = "0x186E769A0")]
		public ECBIHKACAMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static OBLKNCNEFLP HHLLGIIPDKC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static OBLKNCNEFLP LONMIMAJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6E77CB0", Offset = "0x6E76CB0", VA = "0x186E77CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float KAFNJMECABP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected OBLKNCNEFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MACEGDFFACH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MKCCGLFKGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DIHMDMOKEDJ<T> : MACEGDFFACH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> LJBGLDHADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	OBJFFICJNII<T> JBMDKMDJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ONABIJIEMAG
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x314BE50", Offset = "0x314AE50", VA = "0x18314BE50")]
	public static DIHMDMOKEDJ<TResource> AJGCIONCJFA<TResource, TId>(this OAOFDKPFEAD<TId, TResource> NBMFIGMFHDG, TId JHCIODFGPNM, [Optional] Func<TId, CancellationToken, Task<TResource>>? JOPLMFNMCMP) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MKEKAMFECHB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class AINHIJOJDLI<T> : DGEDOOCBMOL<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override OBJFFICJNII<T?> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x41A74A0", Offset = "0x41A64A0", VA = "0x1841A74A0")]
		public AINHIJOJDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class CBIMCBBHLFB<T> : DGEDOOCBMOL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T LKIDDBLKJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? NEPHIECEEGP;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override OBJFFICJNII<T> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5707990", Offset = "0x5706990", VA = "0x185707990")]
		public CBIMCBBHLFB(T PJCBCPDOGAA, Action<T>? PKDGHKHNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5707740", Offset = "0x5706740", VA = "0x185707740", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class LPNMIBJEBGF<T> : DGEDOOCBMOL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override OBJFFICJNII<T> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4764FB0", Offset = "0x4763FB0", VA = "0x184764FB0")]
		public LPNMIBJEBGF(Exception ONPDAAPKDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class HIJBLLFJGLP<T> : DGEDOOCBMOL<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct JIPMEJHCFLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<DIHMDMOKEDJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<DIHMDMOKEDJ<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x45940F0", Offset = "0x45930F0", VA = "0x1845940F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4594630", Offset = "0x4593630", VA = "0x184594630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct OIIAHAAMOFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<DIHMDMOKEDJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<DIHMDMOKEDJ<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4B12F10", Offset = "0x4B11F10", VA = "0x184B12F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4B13150", Offset = "0x4B12150", VA = "0x184B13150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<DIHMDMOKEDJ<T>> BLDBAKGPCNC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override OBJFFICJNII<T> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x41FC480", Offset = "0x41FB480", VA = "0x1841FC480")]
		public HIJBLLFJGLP(Task<DIHMDMOKEDJ<T>> KDFIPCHFLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x41FC0F0", Offset = "0x41FB0F0", VA = "0x1841FC0F0", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x41FC300", Offset = "0x41FB300", VA = "0x1841FC300")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HIJBLLFJGLP<>.JIPMEJHCFLF))]
		internal static Task<T> FMICPLAIFMD(Task<DIHMDMOKEDJ<T>> KDFIPCHFLGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x41FBE80", Offset = "0x41FAE80", VA = "0x1841FBE80")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HIJBLLFJGLP<>.OIIAHAAMOFJ))]
		internal static Task ALAMKDAPFIC(Task<DIHMDMOKEDJ<T>> KDFIPCHFLGF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class BLPPODKIBGB<TIn, TOut> : DGEDOOCBMOL<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct BBPFJELMCPC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x52F1190", Offset = "0x52F0190", VA = "0x1852F1190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4595C40", Offset = "0x4594C40", VA = "0x184595C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly DIHMDMOKEDJ<TIn> HHNEOEHIJOO;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override OBJFFICJNII<TOut> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5363270", Offset = "0x5362270", VA = "0x185363270")]
		public BLPPODKIBGB(DIHMDMOKEDJ<TIn> FOBJPCHPBFO, Func<TIn, TOut> LMCAAAPHPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5362EB0", Offset = "0x5361EB0", VA = "0x185362EB0", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5362F50", Offset = "0x5361F50", VA = "0x185362F50")]
		[AsyncStateMachine(typeof(BLPPODKIBGB<, >.BBPFJELMCPC))]
		[CompilerGenerated]
		internal static Task<TOut> OIPAPOCLOHO(Task<TIn> DDMEOAEPJBC, Func<TIn, TOut> LMCAAAPHPCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3089090", Offset = "0x3088090", VA = "0x183089090")]
	public static DIHMDMOKEDJ<T> BOAMOHHEBKK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3089110", Offset = "0x3088110", VA = "0x183089110")]
	public static DIHMDMOKEDJ<T> CMHNMFBGKAC<T>(T POCKBMKNJHC, [Optional] Action<T>? PKDGHKHNOJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static DIHMDMOKEDJ<T> LAKENNJMAIN<T>(Exception ONPDAAPKDCJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static DIHMDMOKEDJ<T> EIKADBHHAMM<T>(Task<DIHMDMOKEDJ<T>> KDFIPCHFLGF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6380", Offset = "0x2DB5380", VA = "0x182DB6380")]
	public static DIHMDMOKEDJ<TOut> JAFJFBMIFFH<TOut, TIn>(DIHMDMOKEDJ<TIn> GCBNNIKBPHJ, Func<TIn, TOut> LMCAAAPHPCE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class DGEDOOCBMOL<T> : DIHMDMOKEDJ<T>, MACEGDFFACH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string NHBCKOCICND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly PEIKIFBHNLD EFKDNJMONAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool GNHIBNEGODJ;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool MKCCGLFKGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xF63200", Offset = "0xF62200", VA = "0x180F63200", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> LJBGLDHADMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract OBJFFICJNII<T> JBMDKMDJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D78CA0", Offset = "0x5D77CA0", VA = "0x185D78CA0")]
	public DGEDOOCBMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5D78960", Offset = "0x5D77960", VA = "0x185D78960", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FDFMEFJGFOE();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class BALDHGIADLH<TTask, T> : DGEDOOCBMOL<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KOHHAMMHKJO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public KOHHAMMHKJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3947A80", Offset = "0x3946A80", VA = "0x183947A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3947FF0", Offset = "0x3946FF0", VA = "0x183947FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BALDHGIADLH<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KOHHAMMHKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x46A98D0", Offset = "0x46A88D0", VA = "0x1846A98D0")]
		[AsyncStateMachine(typeof(BALDHGIADLH<, >.KOHHAMMHKJO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MINBOJDBBJG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> KDFIPCHFLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource OCGANIIFAKG;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> LJBGLDHADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override OBJFFICJNII<T> JBMDKMDJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x52EB510", Offset = "0x52EA510", VA = "0x1852EB510")]
	protected BALDHGIADLH(TTask KDFIPCHFLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x52EB4C0", Offset = "0x52EA4C0", VA = "0x1852EB4C0", Slot = "10")]
	protected override void FDFMEFJGFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ELLPKGJKPLC(TTask JKAJPAEGJIL);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BDNOPBPGHDF();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HNICIBGMIBC<T> : DGEDOOCBMOL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CLCEBAEDACG<Task<T>> NFOINPMIPGF;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> LJBGLDHADMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x420E270", Offset = "0x420D270", VA = "0x18420E270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override OBJFFICJNII<T> JBMDKMDJKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x420E2D0", Offset = "0x420D2D0", VA = "0x18420E2D0")]
	public HNICIBGMIBC(CLCEBAEDACG<Task<T>> ACIGOBAOCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x420E250", Offset = "0x420D250", VA = "0x18420E250", Slot = "10")]
	protected override void FDFMEFJGFOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class HDLLCJEKGOO
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName MJHCLKNKKIP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> FHPHIEHEPCO;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E76E20", Offset = "0x6E75E20", VA = "0x186E76E20")]
	public static int ADDJMGANPDO(this HDONDABALHH OGHCIBIEIKF, IncrementalHash DFDCMIDOIMI, byte[] ABDBLNCPFJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E774E0", Offset = "0x6E764E0", VA = "0x186E774E0")]
	public static bool JBBGGNIFENJ([CanBeNull] this HDONDABALHH OGHCIBIEIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6E771D0", Offset = "0x6E761D0", VA = "0x186E771D0")]
	public static bool JBBGGNIFENJ([CanBeNull] this HDONDABALHH OGHCIBIEIKF, [Out] string IPLILPPMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E76EA0", Offset = "0x6E75EA0", VA = "0x186E76EA0")]
	public static bool JBBGGNIFENJ([CanBeNull] this HDONDABALHH OGHCIBIEIKF, IncrementalHash DFDCMIDOIMI, byte[] ABDBLNCPFJJ, [Out] string IPLILPPMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6E77540", Offset = "0x6E76540", VA = "0x186E77540")]
	private static bool LKLLJNNECDP(byte[] ACOGMCLHIDO, Span<byte> DCAKGLCJFHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HEMLKLONEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E77970", Offset = "0x6E76970", VA = "0x186E77970")]
	public static int BHGOMHJKECE(HashAlgorithmName APCMLEBAOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E77710", Offset = "0x6E76710", VA = "0x186E77710")]
	public static int ADDJMGANPDO(this APHCFBPPFBL CMDPCHFONBN, byte[] KJCIMHJMJEI, IncrementalHash DFDCMIDOIMI, byte[] AFJNEIBHOPG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface APHCFBPPFBL
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DFDCMIDOIMI);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HDONDABALHH : APHCFBPPFBL
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] JDANOFBGLCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] KCJIJPIOBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OFMDGKILJKM
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool EAAKLEFKMBD;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> GDJPKLKOHNI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> PCGEEJAKKOH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding MNLKKHHJNEM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> JBCECBMEGOI;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3146F10", Offset = "0x3145F10", VA = "0x183146F10")]
	public static void HFDBMGFNDOI<T>(this IncrementalHash JGHOAECEGGD, [CanBeNull] T GEICOLLOJJK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3147600", Offset = "0x3146600", VA = "0x183147600")]
	public static void PJGFDIPFNGG<T>(this IncrementalHash JGHOAECEGGD, [CanBeNull] T CMDPCHFONBN) where T : APHCFBPPFBL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x31469F0", Offset = "0x31459F0", VA = "0x1831469F0")]
	public static void FPPOLLDGEED<T>(this IncrementalHash JGHOAECEGGD, [CanBeNull] IList<T> AKIOFOGMPCD) where T : APHCFBPPFBL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6E78850", Offset = "0x6E77850", VA = "0x186E78850")]
	private static bool JFLCKEGHBFC([CanBeNull] APHCFBPPFBL CMDPCHFONBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6E788E0", Offset = "0x6E778E0", VA = "0x186E788E0")]
	public static void KKDCJHEAFDC(this IncrementalHash DFDCMIDOIMI, string? FDLKPLGKPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6E78280", Offset = "0x6E77280", VA = "0x186E78280")]
	public static void FFAGPKGHJOI(this IncrementalHash DFDCMIDOIMI, long FIADKMFFGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6E77E70", Offset = "0x6E76E70", VA = "0x186E77E70")]
	public static void CJHHHEKKICA(this IncrementalHash DFDCMIDOIMI, int KPOPCMABHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6E78680", Offset = "0x6E77680", VA = "0x186E78680")]
	public static void HAMHOPMBKFH(this IncrementalHash DFDCMIDOIMI, short ODBMKDMPIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6E78040", Offset = "0x6E77040", VA = "0x186E78040")]
	public static void DCJCPIHONNK(this IncrementalHash DFDCMIDOIMI, byte NHGPJOCPDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6E784B0", Offset = "0x6E774B0", VA = "0x186E784B0")]
	public static void FHJPOEMKOIK(this IncrementalHash DFDCMIDOIMI, bool OJEDBBAAEME, bool CGDMHFFFBLM = false, bool IOCNLMFFALA = false, bool IFLEJLNHLAD = false, bool GJEKFCCMGOL = false, bool DCALNIGIPEG = false, bool FEKFJFOKEPH = false, bool ODAGGNOEKLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3146FD0", Offset = "0x3145FD0", VA = "0x183146FD0")]
	public static void NMNOBKBHNBI<T>(this IncrementalHash DFDCMIDOIMI, T FIAIOBCELLH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6E78CE0", Offset = "0x6E77CE0", VA = "0x186E78CE0")]
	public static void KMJMFDNFILK(this IncrementalHash DFDCMIDOIMI, float EKBHLFINIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6E78620", Offset = "0x6E77620", VA = "0x186E78620")]
	public static void GKPKAMIDHKH(this IncrementalHash DFDCMIDOIMI, ulong APAHGDKKOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6E78450", Offset = "0x6E77450", VA = "0x186E78450")]
	public static void FFEDNIDOELB(this IncrementalHash DFDCMIDOIMI, uint MIGCLFHIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6E77E10", Offset = "0x6E76E10", VA = "0x186E77E10")]
	public static void CBAHGOLMJEF(this IncrementalHash DFDCMIDOIMI, ushort BHPENEAEGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6E78150", Offset = "0x6E77150", VA = "0x186E78150")]
	public static void EDKLDNIKJKK(this IncrementalHash DFDCMIDOIMI, Vector3 OCOOFGFDEJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FAOAPAMOIDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6E76AC0", Offset = "0x6E75AC0", VA = "0x186E76AC0")]
	public FAOAPAMOIDC(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class IDNFEJGADFG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class OBFMOPCJJPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode GFJPFDOHONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode JNLBEALAMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AGJBCFGHJKE MPFENKGEFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<AGJBCFGHJKE> CACMOMMGFFG;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OBFMOPCJJPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct AGJBCFGHJKE : IComparable<AGJBCFGHJKE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int IPAOJGBKAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant NIGFLINDJEI;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x11B3E40", Offset = "0x11B2E40", VA = "0x1811B3E40")]
		public AGJBCFGHJKE(int IPAOJGBKAGO, TClaimant NIGFLINDJEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x419F4B0", Offset = "0x419E4B0", VA = "0x18419F4B0")]
		public bool IOHAHDMEKKK([In] AGJBCFGHJKE DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x419F490", Offset = "0x419E490", VA = "0x18419F490")]
		public bool AHMONBKNLIE([In] AGJBCFGHJKE DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x419F4A0", Offset = "0x419E4A0", VA = "0x18419F4A0", Slot = "4")]
		public int CompareTo(AGJBCFGHJKE DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x419F510", Offset = "0x419E510", VA = "0x18419F510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum KFINFOLKNOE
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GEPFJKOENDO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public IDNFEJGADFG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public GEPFJKOENDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4161220", Offset = "0x4160220", VA = "0x184161220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4161400", Offset = "0x4160400", VA = "0x184161400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4161300", Offset = "0x4160300", VA = "0x184161300", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C79910", Offset = "0x3C78910", VA = "0x183C79910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly OANBCOLHEBN<OBFMOPCJJPK> GCEKLLMHFNA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly OANBCOLHEBN<List<AGJBCFGHJKE>> MDPKEKLLIDA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int EBPLJIHGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> JMCDEBHPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, OBFMOPCJJPK> NJABCIINJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KFINFOLKNOE CGGPIBJAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode HPPHCJCMFOO(TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MJJHHOJLFNE(TNode CHMIAHGMJKI, TClaimant KHJCABFGGEB, TClaimant NALMDOFOOAF);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x42F1030", Offset = "0x42F0030", VA = "0x1842F1030")]
	public IDNFEJGADFG(KFINFOLKNOE CGGPIBJAEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x42EF8A0", Offset = "0x42EE8A0", VA = "0x1842EF8A0")]
	public void CKEDFNGGBHE(TNode CHMIAHGMJKI, TNode LNEILPPCDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x42F0C40", Offset = "0x42EFC40", VA = "0x1842F0C40")]
	public void PDKOAOLGHAO(TClaimant NIGFLINDJEI, TNode NFPFIIJFIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x42EFA40", Offset = "0x42EEA40", VA = "0x1842EFA40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x42EF970", Offset = "0x42EE970", VA = "0x1842EF970")]
	private void DGLHLBHHGJD(TClaimant NIGFLINDJEI, TNode OGOCLIDBLLJ, TNode NFPFIIJFIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x42F0DE0", Offset = "0x42EFDE0", VA = "0x1842F0DE0")]
	private int PNBFFHODBCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x42F03F0", Offset = "0x42EF3F0", VA = "0x1842F03F0")]
	private void MPBJCDIMAJP(TClaimant NIGFLINDJEI, TNode MLBCEGKBGPC, TNode AMNHNHKCJLM, int CLFGNKLPJDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x42F0010", Offset = "0x42EF010", VA = "0x1842F0010")]
	private void JGNKKLNNIEN(AGJBCFGHJKE APLOBMLOHGA, OBFMOPCJJPK CGLIBNPLPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x42F00F0", Offset = "0x42EF0F0", VA = "0x1842F00F0")]
	private void KACDFPGPOKA(TClaimant NIGFLINDJEI, TNode MLBCEGKBGPC, TNode AMNHNHKCJLM, int CLFGNKLPJDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x42EF760", Offset = "0x42EE760", VA = "0x1842EF760")]
	private void CILHBLADCGG(AGJBCFGHJKE APLOBMLOHGA, TNode CHMIAHGMJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x42EF5F0", Offset = "0x42EE5F0", VA = "0x1842EF5F0")]
	private void AEAPECOACEE(AGJBCFGHJKE APLOBMLOHGA, OBFMOPCJJPK CGLIBNPLPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x42F0750", Offset = "0x42EF750", VA = "0x1842F0750")]
	private void NPFFIJGBJGP(OBFMOPCJJPK CGLIBNPLPJF, bool JMDLOKLNGIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x42F08B0", Offset = "0x42EF8B0", VA = "0x1842F08B0")]
	private void PBDCIEHNHNJ(OBFMOPCJJPK CGLIBNPLPJF, TNode LNEILPPCDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x42EFF10", Offset = "0x42EEF10", VA = "0x1842EFF10")]
	[IteratorStateMachine(typeof(IDNFEJGADFG<, >.GEPFJKOENDO))]
	private IEnumerable<TNode> INBHKPMLFHF(TNode MLBCEGKBGPC, TNode AMNHNHKCJLM, bool HKKCKGOANDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x42EFC60", Offset = "0x42EEC60", VA = "0x1842EFC60")]
	private OBFMOPCJJPK EALLEFMMOLK(TNode CHMIAHGMJKI, TNode JNLBEALAMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x42EFD80", Offset = "0x42EED80", VA = "0x1842EFD80")]
	private OBFMOPCJJPK FCGLBDKIONL(TNode CHMIAHGMJKI, TNode JNLBEALAMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x42EF420", Offset = "0x42EE420", VA = "0x1842EF420")]
	private void ACEMDNMHOLC(OBFMOPCJJPK CGLIBNPLPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JPBJNKHOEPB<T> : IEnumerable<JPBJNKHOEPB<T>.LJHDCINFNKO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct LJHDCINFNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T BJDKOHEGDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int KHAIDMGPIED;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class JDIDBCFOLNI : IEnumerator<LJHDCINFNKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private JPBJNKHOEPB<T> CDMHNBPIDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int KHAIDMGPIED;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3C7F110", Offset = "0x3C7E110", VA = "0x183C7F110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public LJHDCINFNKO OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4573000", Offset = "0x4572000", VA = "0x184573000", Slot = "4")]
			get
			{
				return default(LJHDCINFNKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4572FC0", Offset = "0x4571FC0", VA = "0x184572FC0")]
		public JDIDBCFOLNI(JPBJNKHOEPB<T> CDMHNBPIDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4572EC0", Offset = "0x4571EC0", VA = "0x184572EC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5800", Offset = "0x3CD4800", VA = "0x183CD5800", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xD02B40", Offset = "0xD01B40", VA = "0x180D02B40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct CMJNMMEIEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool FLFBLEJNDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T BJDKOHEGDOK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int NGJOPHFDMHI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> LMAFHJGCANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private CMJNMMEIEPI[] LEOANDJFPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int MLCGJBBOJJF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int EKODPBDBNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F5FB0", Offset = "0x8F4FB0", VA = "0x1808F5FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F55A0", Offset = "0x8F45A0", VA = "0x1808F55A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x395A3E0", Offset = "0x39593E0", VA = "0x18395A3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x45BDC10", Offset = "0x45BCC10", VA = "0x1845BDC10")]
	public JPBJNKHOEPB(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x45BD7D0", Offset = "0x45BC7D0", VA = "0x1845BD7D0")]
	public JPBJNKHOEPB(LJHDCINFNKO[] IEGGKOANPPC, bool NHIPKEKHECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x45BD070", Offset = "0x45BC070", VA = "0x1845BD070")]
	public int MKACCPCPACH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x45BCA40", Offset = "0x45BBA40", VA = "0x1845BCA40")]
	private int CDGNNPFDEFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x45BCF80", Offset = "0x45BBF80", VA = "0x1845BCF80", Slot = "6")]
	protected virtual uint IPNCEIPHPMK(uint DFDCMIDOIMI, T BJDKOHEGDOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x45BC870", Offset = "0x45BB870", VA = "0x1845BC870")]
	public bool BPJPJKHHOKJ(T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x45BC930", Offset = "0x45BB930", VA = "0x1845BC930")]
	public int CCNODBCCDDN(T BJDKOHEGDOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x45BD000", Offset = "0x45BC000", VA = "0x1845BD000")]
	public T JAEBKCPHLDG(int KHAIDMGPIED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x45BD660", Offset = "0x45BC660", VA = "0x1845BD660")]
	public bool OFBEPAEKHBO(T BJDKOHEGDOK, bool AMFPHAFFNON = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x45BD3F0", Offset = "0x45BC3F0", VA = "0x1845BD3F0")]
	public bool OFBEPAEKHBO(T BJDKOHEGDOK, int KHAIDMGPIED, bool AMFPHAFFNON = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x45BCEB0", Offset = "0x45BBEB0", VA = "0x1845BCEB0")]
	private int EIEJKGOJCFO(int KECPKLHBJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x45BD730", Offset = "0x45BC730", VA = "0x1845BD730", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x45BD730", Offset = "0x45BC730", VA = "0x1845BD730", Slot = "4")]
	private IEnumerator<LJHDCINFNKO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OANBCOLHEBN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> KFPDBBNOEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> ONNOCBJCLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int HLHLLCKLEAP;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8920", Offset = "0x4AD7920", VA = "0x184AD8920")]
	public static OANBCOLHEBN<T> GHIMBOFKJJC(int BHNNGJABFPL = 0, int HLHLLCKLEAP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8150", Offset = "0x4AD7150", VA = "0x184AD8150")]
	public static OANBCOLHEBN<T> AKLJMECLGMD(int BHNNGJABFPL = 0, int HLHLLCKLEAP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8C90", Offset = "0x4AD7C90", VA = "0x184AD8C90")]
	public OANBCOLHEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8A70", Offset = "0x4AD7A70", VA = "0x184AD8A70")]
	public OANBCOLHEBN(int BHNNGJABFPL, int HLHLLCKLEAP = int.MaxValue, bool MLDONJKAOOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8740", Offset = "0x4AD7740", VA = "0x184AD8740")]
	public T EDGCLAMDNDK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4AD84C0", Offset = "0x4AD74C0", VA = "0x184AD84C0")]
	public void DIPKALJLHOB(T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8050", Offset = "0x4AD7050", VA = "0x184AD8050")]
	private void ACMKLHCMCID(T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8A20", Offset = "0x4AD7A20", VA = "0x184AD8A20")]
	private void NJODBJNBMEH(T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4AD85B0", Offset = "0x4AD75B0", VA = "0x184AD85B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8250", Offset = "0x4AD7250", VA = "0x184AD8250")]
	private void DIDOECKIIFL(IEnumerable<T> CMDOFHABOHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MONHOLNNICN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> LMPEOFNFEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T KKCPANPGHEE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T KAICMBBAEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x49722D0", Offset = "0x49712D0", VA = "0x1849722D0")]
	public bool ALENMIAKIAD(T BJDKOHEGDOK, int IPAOJGBKAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4378B20", Offset = "0x4377B20", VA = "0x184378B20")]
	public bool HKHPJBJFLMH(int IPAOJGBKAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4972760", Offset = "0x4971760", VA = "0x184972760")]
	public T IDHMBFDFGHH(int LOPGGHINLMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4972380", Offset = "0x4971380", VA = "0x184972380")]
	private bool FDEGGJDCAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4972980", Offset = "0x4971980", VA = "0x184972980")]
	public bool JIBJJFGCKGK(int IPAOJGBKAGO, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4379040", Offset = "0x4378040", VA = "0x184379040")]
	public MONHOLNNICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FKNHNHDNEMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct FIJFNMGCLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T DMNEEJMINJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int COECKJBGBIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<FIJFNMGCLDL> HOHLANLKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T OFGAACLFNDK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x395A3E0", Offset = "0x39593E0", VA = "0x18395A3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x400E660", Offset = "0x400D660", VA = "0x18400E660")]
	public bool KOLCIDGNCMK(T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x400EA60", Offset = "0x400DA60", VA = "0x18400EA60")]
	public void OPFOFHIGBEE(T BJDKOHEGDOK, int IPAOJGBKAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x400E260", Offset = "0x400D260", VA = "0x18400E260")]
	public bool CAKBCGBONLK(T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x400E470", Offset = "0x400D470", VA = "0x18400E470")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x400E520", Offset = "0x400D520", VA = "0x18400E520")]
	public T FCCCPKGAPGP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x400DF40", Offset = "0x400CF40", VA = "0x18400DF40")]
	protected void BNCBPNDFLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x400EC00", Offset = "0x400DC00", VA = "0x18400EC00")]
	public FKNHNHDNEMA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6E79240", Offset = "0x6E78240", VA = "0x186E79240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6E79510", Offset = "0x6E78510", VA = "0x186E79510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E79420", Offset = "0x6E78420", VA = "0x186E79420")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6E79190", Offset = "0x6E78190", VA = "0x186E79190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6E79460", Offset = "0x6E78460", VA = "0x186E79460")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6E79370", Offset = "0x6E78370", VA = "0x186E79370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E79110", Offset = "0x6E78110", VA = "0x186E79110")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9500", Offset = "0x4DA8500", VA = "0x184DA9500", Slot = "4")]
		public virtual T OHNOPLOJPGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class CBMHOJLIPNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, APKKKPDNLIM> KOJJHIBNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly OANBCOLHEBN<APKKKPDNLIM> KEDBJEKGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool NMHJAMDLMBD;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public APKKKPDNLIM NDLMNCFANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 KFEKPBDKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1119250", Offset = "0x1118250", VA = "0x181119250")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x142F560", Offset = "0x142E560", VA = "0x18142F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 BOGIBGMFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x92B0E0", Offset = "0x92A0E0", VA = "0x18092B0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 GCDJGGJKJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E76260", Offset = "0x6E75260", VA = "0x186E76260")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA080", Offset = "0x8B9080", VA = "0x1808BA080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int PNGEOOEKBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C3130", Offset = "0x8C2130", VA = "0x1808C3130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C34A0", Offset = "0x8C24A0", VA = "0x1808C34A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E766F0", Offset = "0x6E756F0", VA = "0x186E766F0")]
	public CBMHOJLIPNM(Bounds IJBOAHKJCKJ, Vector2[] FGLDNFFJNJD, int JPNDMLKNCBB, byte KECPKLHBJEB, float PNEOGDAHKAA = 0f, [Optional] OANBCOLHEBN<APKKKPDNLIM> KEDBJEKGALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E75740", Offset = "0x6E74740", VA = "0x186E75740")]
	public void AAKDPLOHELD(Bounds IJBOAHKJCKJ, Vector2[] FGLDNFFJNJD, int JPNDMLKNCBB, byte KECPKLHBJEB, float PNEOGDAHKAA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E75F90", Offset = "0x6E74F90", VA = "0x186E75F90")]
	public APKKKPDNLIM CMFJECHGPKM(byte KHAIDMGPIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E760B0", Offset = "0x6E750B0", VA = "0x186E760B0")]
	public void GOACDNGDKPE(Vector3 PAMMLHPIJIB, float ODBHNKBNPPN, float KGFHMEPHNDJ, List<byte> PECIBGLGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E76280", Offset = "0x6E75280", VA = "0x186E76280")]
	public void KHAKLNBMIDP(APKKKPDNLIM.EGIKKEOGIBC MNBAIPKOEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E76180", Offset = "0x6E75180", VA = "0x186E76180")]
	public static int GOLHMGFLFPI(Vector2[] FGLDNFFJNJD, int JPNDMLKNCBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E762A0", Offset = "0x6E752A0", VA = "0x186E762A0")]
	private APKKKPDNLIM LKGLFIJBKOD(byte KHAIDMGPIED, APKKKPDNLIM.BDCKBCDDBJF LCBAMHDJINP, APKKKPDNLIM JNLBEALAMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E75BD0", Offset = "0x6E74BD0", VA = "0x186E75BD0")]
	private void BMGOKMKLNPM(APKKKPDNLIM JNLBEALAMNB, Vector2[] FGLDNFFJNJD, int KHEHMMINAKA, int FBKBEIPMNDH, int JDCHOKINABH, int KNEJDBPFMDI, float PNEOGDAHKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E764D0", Offset = "0x6E754D0", VA = "0x186E764D0")]
	private void POLOOEDLMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6E75FF0", Offset = "0x6E74FF0", VA = "0x186E75FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6E76050", Offset = "0x6E75050", VA = "0x186E76050", Slot = "1")]
	~CBMHOJLIPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class APKKKPDNLIM
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum BDCKBCDDBJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum EGIKKEOGIBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte CCDGLKPMLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 FAMPJPKNBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 IIJOJMFBBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 AKGIJHANKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 JELCHJOLNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BDCKBCDDBJF HJCHIBILKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public APKKKPDNLIM CDPDLODOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<APKKKPDNLIM> FJNKJKEMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool AGCLCFOMDHE;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6E756B0", Offset = "0x6E746B0", VA = "0x186E756B0")]
	public APKKKPDNLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6E75570", Offset = "0x6E74570", VA = "0x186E75570")]
	public void OCDDLLPCHEM(APKKKPDNLIM KOOGBCPBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public void KHAKLNBMIDP(int CFIJLCANJNE, EGIKKEOGIBC MNBAIPKOEFB, int GAMNIEOKDIE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6E752E0", Offset = "0x6E742E0", VA = "0x186E752E0")]
	public void GOACDNGDKPE(List<byte> PECIBGLGDFC, Vector3 PAMMLHPIJIB, float ODBHNKBNPPN, float KGFHMEPHNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6E75220", Offset = "0x6E74220", VA = "0x186E75220")]
	public bool BCCONEFEAPN(Vector3 DCLNJEJCMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6E75540", Offset = "0x6E74540", VA = "0x186E75540")]
	public bool HEKGEOKLEMJ(Vector3 DCLNJEJCMFG, float FMLHDHKODKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6E75250", Offset = "0x6E74250", VA = "0x186E75250")]
	public void CPDDJGLEDNE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct BPMOAAEGJED<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> AKKGGCHEPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool ODMKGDMEBPB;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x422BCA0", Offset = "0x422ACA0", VA = "0x18422BCA0")]
			public BPMOAAEGJED(List<Component> AKKGGCHEPCI, bool ODMKGDMEBPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x53EBB80", Offset = "0x53EAB80", VA = "0x1853EBB80")]
			public KFBNGPHDAEH<T> EMFBOAAPBLH()
			{
				return default(KFBNGPHDAEH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x53EBBF0", Offset = "0x53EABF0", VA = "0x1853EBBF0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x53EBBF0", Offset = "0x53EABF0", VA = "0x1853EBBF0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct KFBNGPHDAEH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> AKKGGCHEPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool ODMKGDMEBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int KHAIDMGPIED;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T OEJFPPMIFNH
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x4676280", Offset = "0x4675280", VA = "0x184676280", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x4676210", Offset = "0x4675210", VA = "0x184676210", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4676250", Offset = "0x4675250", VA = "0x184676250")]
			public KFBNGPHDAEH(List<Component> AKKGGCHEPCI, bool ODMKGDMEBPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4676150", Offset = "0x4675150", VA = "0x184676150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x4676160", Offset = "0x4675160", VA = "0x184676160", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3CC6AE0", Offset = "0x3CC5AE0", VA = "0x183CC6AE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6E7AF00", Offset = "0x6E79F00", VA = "0x186E7AF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A820", Offset = "0x6E79820", VA = "0x186E7A820")]
		private void CPDDJGLEDNE(GameObject LKPFEGDHPHH, bool OCPABOGIINL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7A990", Offset = "0x6E79990", VA = "0x186E7A990")]
		public static void CPDDJGLEDNE(GameObject LKPFEGDHPHH, ToolHierarchyCache NBMFIGMFHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AAA0", Offset = "0x6E79AA0", VA = "0x186E7AAA0")]
		public void FLNPIMAKDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x32B78E0", Offset = "0x32B68E0", VA = "0x1832B78E0")]
		public void LFDNJGFHGBN<T>(Action<T> NDLMGANFCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x32B7780", Offset = "0x32B6780", VA = "0x1832B7780")]
		public T BJIHJAEMEFA<T>(bool ODMKGDMEBPB = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x32B7820", Offset = "0x32B6820", VA = "0x1832B7820")]
		public BPMOAAEGJED<T> CDMFDMEMKML<T>(bool ODMKGDMEBPB = false) where T : class
		{
			return default(BPMOAAEGJED<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AB20", Offset = "0x6E79B20", VA = "0x186E7AB20")]
		public List<Component> LAGFGGAOLJE(Type PFCMGBLCCPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AA20", Offset = "0x6E79A20", VA = "0x186E7AA20", Slot = "4")]
		public bool Equals(ToolHierarchyCache GOCMFEAMGHO, ToolHierarchyCache AEFHGLLPABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AAB0", Offset = "0x6E79AB0", VA = "0x186E7AAB0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache IFPBFCLBBDP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PDNMHDEMKHI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BHNNGJABFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int JBMMFLINDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> KKKPLHGNHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x420E270", Offset = "0x420D270", VA = "0x18420E270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T CENFMIKPMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4BD8EF0", Offset = "0x4BD7EF0", VA = "0x184BD8EF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T PAGIHPLPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4BD90A0", Offset = "0x4BD80A0", VA = "0x184BD90A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T OCDJBCFGGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4BD9200", Offset = "0x4BD8200", VA = "0x184BD9200")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4BD9600", Offset = "0x4BD8600", VA = "0x184BD9600")]
	public PDNMHDEMKHI(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4BD9280", Offset = "0x4BD8280", VA = "0x184BD9280")]
	public void OPFOFHIGBEE(T KHHBELBCGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4BD8E10", Offset = "0x4BD7E10", VA = "0x184BD8E10")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4BD8D10", Offset = "0x4BD7D10", VA = "0x184BD8D10")]
	public void EFHPDAAKFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4BD8E70", Offset = "0x4BD7E70", VA = "0x184BD8E70")]
	public void HDOCAGOFJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4BD8EE0", Offset = "0x4BD7EE0", VA = "0x184BD8EE0")]
	public void JBDIKDEGJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4BD9560", Offset = "0x4BD8560", VA = "0x184BD9560")]
	public List<T> PKCDBFKJMPN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HGOKKEHDFGJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct ODMOJLCBAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int COECKJBGBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T DMNEEJMINJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, ODMOJLCBAHC> LMPEOFNFEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> DENILCNGJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T KKCPANPGHEE;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T KAICMBBAEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x991650", Offset = "0x990650", VA = "0x180991650", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x41F60E0", Offset = "0x41F50E0", VA = "0x1841F60E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool LHGADJIMJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x41F6040", Offset = "0x41F5040", VA = "0x1841F6040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object LDOKINNEAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x41F22C0", Offset = "0x41F12C0", VA = "0x1841F22C0")]
	public bool ALENMIAKIAD(T BJDKOHEGDOK, object NANMDIJGGLP, int IPAOJGBKAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x41F5670", Offset = "0x41F4670", VA = "0x1841F5670")]
	public bool HKHPJBJFLMH(object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x41F5D20", Offset = "0x41F4D20", VA = "0x1841F5D20")]
	public bool JIBJJFGCKGK(object NANMDIJGGLP, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x41F2790", Offset = "0x41F1790", VA = "0x1841F2790")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x41F4890", Offset = "0x41F3890", VA = "0x1841F4890")]
	private bool FDEGGJDCAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x41F6140", Offset = "0x41F5140", VA = "0x1841F6140")]
	public HGOKKEHDFGJ()
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
